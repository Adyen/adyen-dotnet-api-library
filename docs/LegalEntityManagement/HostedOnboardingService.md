# Adyen.LegalEntityManagement.Services.HostedOnboardingService

### API Base-Path: **https://kyc-test.adyen.com/lem/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLinkToAdyenhostedOnboardingPage**](HostedOnboardingService.md#getlinktoadyenhostedonboardingpage) | **POST** /legalEntities/{id}/onboardingLinks | Get a link to an Adyen-hosted onboarding page |
| [**GetOnboardingLinkTheme**](HostedOnboardingService.md#getonboardinglinktheme) | **GET** /themes/{id} | Get an onboarding link theme |
| [**ListHostedOnboardingPageThemes**](HostedOnboardingService.md#listhostedonboardingpagethemes) | **GET** /themes | Get a list of hosted onboarding page themes |

<a id="getlinktoadyenhostedonboardingpage"></a>
# **POST** **/legalEntities/{id}/onboardingLinks**

Get a link to an Adyen-hosted onboarding page

```csharp 
IOnboardingLink GetLinkToAdyenhostedOnboardingPageAsync(string id, OnboardingLinkInfo onboardingLinkInfo = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the legal entity |
| **onboardingLinkInfo** | [**OnboardingLinkInfo**](OnboardingLinkInfo.md) |  |

### Return type

[**OnboardingLink**](OnboardingLink.md)

<a id="getonboardinglinktheme"></a>
# **GET** **/themes/{id}**

Get an onboarding link theme

```csharp 
IOnboardingTheme GetOnboardingLinkThemeAsync(string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **id** | **string** | The unique identifier of the theme |

### Return type

[**OnboardingTheme**](OnboardingTheme.md)

<a id="listhostedonboardingpagethemes"></a>
# **GET** **/themes**

Get a list of hosted onboarding page themes

```csharp 
IOnboardingThemes ListHostedOnboardingPageThemesAsync()
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OnboardingThemes**](OnboardingThemes.md)

