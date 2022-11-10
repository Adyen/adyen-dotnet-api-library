generator:=csharp-netcore
openapi-generator-cli:=docker run --user $(shell id -u):$(shell id -g) --rm -v /home/vagrant/adyen-dotnet-api-library:/local -w /local openapitools/openapi-generator-cli:v6.2.1
services:=checkout


# ${PWD}
 
# Generate models (for each service)
models: $(services)

binlookup: spec=BinLookupService-v52
checkout: spec=CheckoutService-v69
storedValue: spec=StoredValueService-v46
terminalManagement: spec=TfmAPIService-v1
payments: spec=PaymentService-v68
recurring: spec=RecurringService-v68
payouts: spec=PayoutService-v68
management: spec=ManagementService-v1
legalEntityManagement: spec=LegalEntityService-v2
balancePlatform: spec=BalancePlatformService-v2
platformsAccount: spec=AccountService-v6
platformsFund: spec=FundService-v6
platformsNotificationConfiguration: spec=NotificationConfigurationService-v6
platformsHostedOnboardingPage: spec=HopService-v6
transfer: spec=TransferService-v3

$(services): build/spec 
	rm -rf build/Model/$@ build/model
	$(openapi-generator-cli) generate \
		-i build/spec/json/$(spec).json \
		-g $(generator) \
		-o build \
		--global-property models,supportingFiles
	mv build/src/Org.OpenAPITools/Model/* Adyen/Model/$@
	
#adjust this build/src to another file when creating templates

# -t templates/csharp \ 

# Checkout spec (and patch version)
build/spec:
	git clone https://github.com/Adyen/adyen-openapi.git build/spec
	perl -i -pe 's/"openapi" : "3.[0-9].[0-9]"/"openapi" : "3.0.0"/' build/spec/json/*.json

# Extract templates (copy them for modifications)
#templates:
#	$(openapi-generator-cli) author template -g $(generator) -o build/templates/csharp

# Discard generated artifacts and changed models
clean:
	git checkout Adyen/Model
	git clean -f -d Adyen/Model

.PHONY: templates models $(services)