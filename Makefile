openapi-generator-version:=6.2.1
openapi-generator-url:=https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/$(openapi-generator-version)/openapi-generator-cli-$(openapi-generator-version).jar
openapi-generator-jar:=target/openapi-generator-cli.jar
openapi-generator-cli:=java -jar $(openapi-generator-jar)


generator:=csharp-netcore
services:=BalanceControl BalancePlatform BinLookup Checkout DataProtection LegalEntityManagement Management Payments Payouts PosTerminalManagement Recurring StoredValue Transfers
models:=Adyen/Model
output:=target/out

# Generate models (for each service)
models: $(services)

BalanceControl: spec=BalanceControlService-v1
BalancePlatform: spec=BalancePlatformService-v2
BinLookup: spec=BinLookupService-v54
Checkout: spec=CheckoutService-v70
DataProtection: spec=DataProtectionService-v1
StoredValue: spec=StoredValueService-v46
PosTerminalManagement: spec=TfmAPIService-v1
Payments: spec=PaymentService-v68
Recurring: spec=RecurringService-v68
Payout: spec=PayoutService-v68
Management: spec=ManagementService-v1
LegalEntityManagement: spec=LegalEntityService-v3
PlatformsAccount: spec=AccountService-v6
PlatformsFund: spec=FundService-v6
PlatformsNotificationConfiguration: spec=NotificationConfigurationService-v6
PlatformsHostedOnboardingPage: spec=HopService-v6
Transfers: spec=TransferService-v3

$(services): target/spec $(openapi-generator-jar) 
	rm -rf $(models)/$@ $(output)
	$(openapi-generator-cli) generate \
		-i target/spec/json/$(spec).json \
		-g $(generator) \
		-t templates/csharp \
		-o $(output) \
		--inline-schema-name-mappings PaymentDonationRequest_paymentMethod=CheckoutPaymentMethod \
		--model-package $@ \
		--skip-validate-spec \
		--reserved-words-mappings Version=Version \
		--global-property modelDocs=false \
        --global-property modelTests=false \
		--global-property models,supportingFiles \
		--additional-properties packageName=Adyen.Model
	mkdir Adyen/Model/$@
	mv target/out/src/Adyen.Model/$@/* Adyen/Model/$@

# Service Generation; split up in to templates based on the size of the service. That is, some services have no subgroups and are thus generated in one single file, others are grouped in a directory.

Services:=BalancePlatform Checkout StoredValue Payments Payout Management LegalEntityManagement Transfers
SingleFileServices:=BalanceControl BinLookup DataProtection StoredValue PosTerminalManagement Recurring

all: $(Services) $(SingleFileServices)

$(Services): target/spec $(openapi-generator-jar)  
	rm -rf $(output)
	$(openapi-generator-cli) generate \
		-i target/spec/json/$(spec).json \
		-g $(generator) \
		-t templates/csharp \
		-o $(output) \
		--inline-schema-name-mappings PaymentDonationRequest_paymentMethod=CheckoutPaymentMethod \
		--additional-properties packageName=Adyen \
		--api-package Service.$@ \
		--api-name-suffix Service \
		--model-package Model.$@ \
		--reserved-words-mappings Version=Version \
		--additional-properties=serviceName=$@
	rm -rf Adyen/Service/$@ Adyen/Model/$@
	mv target/out/src/Adyen/Service.$@ Adyen/Service/$@
	mv target/out/src/Adyen/Model.$@ Adyen/Model/$@
	
$(SingleFileServices): target/spec $(openapi-generator-jar)  
	rm -rf $(output)
	$(openapi-generator-cli) generate \
		-i target/spec/json/$(spec).json \
		-g $(generator) \
		-c templates/csharp/config.yaml \
		-o $(output) \
		--inline-schema-name-mappings PaymentDonationRequest_paymentMethod=CheckoutPaymentMethod \
		--additional-properties packageName=Adyen \
		--additional-properties customApi=$@ \
		--api-package Service.$@ \
		--api-name-suffix Service \
		--model-package Model.$@ \
		--reserved-words-mappings Version=Version \
		--additional-properties=serviceName=$@
	rm -rf Adyen/Service/$@ Adyen/Model/$@
	mv target/out/src/Adyen/Service.$@/*Single.cs Adyen/Service/$@Service.cs
	mv target/out/src/Adyen/Model.$@ Adyen/Model/$@

# Checkout spec (and patch version)
target/spec:
	git clone https://github.com/Adyen/adyen-openapi.git target/spec
	perl -i -pe 's/"openapi" : "3.[0-9].[0-9]"/"openapi" : "3.0.0"/' target/spec/json/*.json

# Extract templates (copy them for modifications)
templates: $(openapi-generator-jar)
	$(openapi-generator-cli) author template -g $(generator) -o target/templates

# Download the generator
$(openapi-generator-jar):
	wget --quiet -o /dev/null $(openapi-generator-url) -O $(openapi-generator-jar)

# Discard generated artifacts and changed models
clean:
	rm -rf $(output)
	git checkout $(models) Adyen/Service/Management
	git clean -f -d $(models) Adyen/Service/Management


.PHONY: templates models $(services)
