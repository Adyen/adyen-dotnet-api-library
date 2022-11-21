generator:=csharp
openapi-generator-cli:=docker run --user $(shell id -u):$(shell id -g) --rm -v ${PWD}:/local -w /local openapitools/openapi-generator-cli:v6.2.1
services:= 


# ${PWD}
 
# Generate models (for each service)
models: $(services)

Binlookup: spec=BinLookupService-v52
Checkout: spec=CheckoutService-v69
StoredValue: spec=StoredValueService-v46
TerminalManagement: spec=TfmAPIService-v1
Payments: spec=PaymentService-v68
Recurring: spec=RecurringService-v68
Payouts: spec=PayoutService-v68
Management: spec=ManagementService-v1
LegalEntityManagement: spec=LegalEntityService-v2
BalancePlatform: spec=BalancePlatformService-v2
PlatformsAccount: spec=AccountService-v6
PlatformsFund: spec=FundService-v6
PlatformsNotificationConfiguration: spec=NotificationConfigurationService-v6
PlatformsHostedOnboardingPage: spec=HopService-v6
Transfer: spec=TransferService-v3

$(services): build/spec 
	rm -rf Adyen/Model/$@ build/model
	$(openapi-generator-cli) generate \
		-i build/spec/json/$(spec).json \
		-g $(generator) \
		-t templates/csharp \
		-o build \
		--model-package $@ \
		--reserved-words-mappings Version=Version \
		--global-property modelDocs=false \
        --global-property modelTests=false \
		--global-property models,supportingFiles \
		--additional-properties packageName=Adyen.Model
	mkdir Adyen/Model/$@
	mv build/src/Adyen.Model/$@/* Adyen/Model/$@
#adjust this build/src to another file when creating templates

# Checkout spec (and patch version)
build/spec:
	git clone https://github.com/Adyen/adyen-openapi.git build/spec
	perl -i -pe 's/"openapi" : "3.[0-9].[0-9]"/"openapi" : "3.0.0"/' build/spec/json/*.json

# Extract templates (copy them for modifications)
templates:
	$(openapi-generator-cli) author template -g $(generator) -o build/templates/csharp

# Discard generated artifacts and changed models
clean:
	git checkout Adyen/Model
	git clean -f -d Adyen/Model

.PHONY: templates models $(services)