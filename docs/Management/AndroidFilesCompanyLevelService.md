# Adyen.Management.Services.AndroidFilesCompanyLevelService

### API Base-Path: **https://management-test.adyen.com/v3**

### Authorization: [ApiKeyAuth](../README.md#ApiKeyAuth), [BasicAuth](../README.md#BasicAuth)

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAndroidApp**](AndroidFilesCompanyLevelService.md#getandroidapp) | **GET** /companies/{companyId}/androidApps/{id} | Get Android app |
| [**ListAndroidApps**](AndroidFilesCompanyLevelService.md#listandroidapps) | **GET** /companies/{companyId}/androidApps | Get a list of Android apps |
| [**ListAndroidCertificates**](AndroidFilesCompanyLevelService.md#listandroidcertificates) | **GET** /companies/{companyId}/androidCertificates | Get a list of Android certificates |
| [**ReprocessAndroidApp**](AndroidFilesCompanyLevelService.md#reprocessandroidapp) | **PATCH** /companies/{companyId}/androidApps/{id} | Reprocess Android App |
| [**UploadAndroidApp**](AndroidFilesCompanyLevelService.md#uploadandroidapp) | **POST** /companies/{companyId}/androidApps | Upload Android App |
| [**UploadAndroidCertificate**](AndroidFilesCompanyLevelService.md#uploadandroidcertificate) | **POST** /companies/{companyId}/androidCertificates | Upload Android Certificate |

<a id="getandroidapp"></a>
# **GET** **/companies/{companyId}/androidApps/{id}**

Get Android app

```csharp 
IAndroidApp GetAndroidAppAsync(string companyId, string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **id** | **string** | The unique identifier of the app. |

### Return type

[**AndroidApp**](AndroidApp.md)

<a id="listandroidapps"></a>
# **GET** **/companies/{companyId}/androidApps**

Get a list of Android apps

```csharp 
IAndroidAppsResponse ListAndroidAppsAsync(string companyId, int pageNumber = null, int pageSize = null, string packageName = null, int versionCode = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| **packageName** | **string** | The package name that uniquely identifies the Android app. |
| **versionCode** | **int** | The version number of the app. |

### Return type

[**AndroidAppsResponse**](AndroidAppsResponse.md)

<a id="listandroidcertificates"></a>
# **GET** **/companies/{companyId}/androidCertificates**

Get a list of Android certificates

```csharp 
IAndroidCertificatesResponse ListAndroidCertificatesAsync(string companyId, int pageNumber = null, int pageSize = null, string certificateName = null)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **pageNumber** | **int** | The number of the page to fetch. |
| **pageSize** | **int** | The number of items to have on a page, maximum 100. The default is 20 items on a page. |
| **certificateName** | **string** | The name of the certificate. |

### Return type

[**AndroidCertificatesResponse**](AndroidCertificatesResponse.md)

<a id="reprocessandroidapp"></a>
# **PATCH** **/companies/{companyId}/androidApps/{id}**

Reprocess Android App

```csharp 
IReprocessAndroidAppResponse ReprocessAndroidAppAsync(string companyId, string id)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |
| **id** | **string** | The unique identifier of the app. |

### Return type

[**ReprocessAndroidAppResponse**](ReprocessAndroidAppResponse.md)

<a id="uploadandroidapp"></a>
# **POST** **/companies/{companyId}/androidApps**

Upload Android App

```csharp 
IUploadAndroidAppResponse UploadAndroidAppAsync(string companyId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |

### Return type

[**UploadAndroidAppResponse**](UploadAndroidAppResponse.md)

<a id="uploadandroidcertificate"></a>
# **POST** **/companies/{companyId}/androidCertificates**

Upload Android Certificate

```csharp 
IUploadAndroidCertificateResponse UploadAndroidCertificateAsync(string companyId)
```

### Parameters

| Name | Type | Description |
|------|------|-------------|
| **companyId** | **string** | The unique identifier of the company account. |

### Return type

[**UploadAndroidCertificateResponse**](UploadAndroidCertificateResponse.md)

