generator:=csharp
openapi-generator-cli:=docker run --user $(shell id -u):$(shell id -g) --rm -v ${PWD}:/local -w /local openapitools/openapi-generator-cli:v6.2.1
services:=BalancePlatform


# ${PWD}
 
# Generate models (for each service)
models: $(services)

binlookup: spec=BinLookupService-v52
Checkout: spec=CheckoutService-v69
storedValue: spec=StoredValueService-v46
terminalManagement: spec=TfmAPIService-v1
payments: spec=PaymentService-v68
recurring: spec=RecurringService-v68
payouts: spec=PayoutService-v68
management: spec=ManagementService-v1
legalEntityManagement: spec=LegalEntityService-v2
BalancePlatform: spec=BalancePlatformService-v2
platformsAccount: spec=AccountService-v6
platformsFund: spec=FundService-v6
platformsNotificationConfiguration: spec=NotificationConfigurationService-v6
platformsHostedOnboardingPage: spec=HopService-v6
Transfer: spec=TransferService-v3

$(services): build/spec 
	rm -rf Adyen/Model/$@ build/model
	$(openapi-generator-cli) generate \
		-i build/spec/json/$(spec).json \
		-g $(generator) \
		-t templates/csharp \
		-o build \
		--model-package $(services) \
		--reserved-words-mappings Version=Version \
		--global-property modelDocs=false \
        --global-property modelTests=false \
		--global-property models,supportingFiles \
		--additional-properties packageName=Adyen.Model
	mkdir Adyen/Model/$@
	mv build/src/Adyen.Model/$@/* Adyen/Model/$@
    rm -r build
	
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