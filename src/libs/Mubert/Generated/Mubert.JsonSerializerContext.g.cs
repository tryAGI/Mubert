
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Mubert
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Mubert.JsonConverters.CommentModelTypeEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.CommentModelTypeEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.CompanyStatusEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.CompanyStatusEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.CustomerStatusEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.CustomerStatusEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.FeatureEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.FeatureEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitResettableFieldEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitResettableFieldEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitStreamingLimitTypeEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitStreamingLimitTypeEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitTracksLimitTypeEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitTracksLimitTypeEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseStatusEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseStatusEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseTypeEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseTypeEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.OrderDirectionEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.OrderDirectionEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.ReportStatusEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.ReportStatusEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.ReportTypeEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.ReportTypeEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.CompanySortEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.CompanySortEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StripeInvoiceBillingReasonEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.StripeInvoiceBillingReasonEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StripeInvoiceStatusEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.StripeInvoiceStatusEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePaymentIntentStatusEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePaymentIntentStatusEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePriceIntervalEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePriceIntervalEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePriceTypeEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePriceTypeEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StripeSubscriptionStatusEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.StripeSubscriptionStatusEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackGenerationStatusEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackGenerationStatusEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.UserRoleEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.UserRoleEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.WebhookStatusEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.WebhookStatusEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitStreamingDurationExceptionTypeJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitStreamingDurationExceptionTypeNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitTracksCountExceptionTypeJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitTracksCountExceptionTypeNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitTracksDurationExceptionTypeJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseLimitTracksDurationExceptionTypeNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.Error403ResponseDiscriminatorCodeJsonConverter),

            typeof(global::Mubert.JsonConverters.Error403ResponseDiscriminatorCodeNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePricePublicResourceTypeJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePricePublicResourceTypeNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePricePublicResourceIntervalJsonConverter),

            typeof(global::Mubert.JsonConverters.StripePricePublicResourceIntervalNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.InstrumentEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.InstrumentEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StemEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.StemEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackFormatEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackFormatEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackIntensityEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackIntensityEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackKeyEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackKeyEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackKeyScaleEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackKeyScaleEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackModeEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackModeEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackScaleEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackScaleEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.BucketEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.BucketEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StreamingLoopStateEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.StreamingLoopStateEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.StreamingTypeEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.StreamingTypeEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.LanguageEnumJsonConverter),

            typeof(global::Mubert.JsonConverters.LanguageEnumNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.GetPublicMusicLibraryTracksOrderJsonConverter),

            typeof(global::Mubert.JsonConverters.GetPublicMusicLibraryTracksOrderNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.GetPublicTracksOrderJsonConverter),

            typeof(global::Mubert.JsonConverters.GetPublicTracksOrderNullableJsonConverter),

            typeof(global::Mubert.JsonConverters.MetadataPaginationSortableJsonConverter),

            typeof(global::Mubert.JsonConverters.AccessTokenIndexPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.AccessTokenShowPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.CompanyIndexPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.CompanyShowPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.CustomerLicenseLimitIndexPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.CustomerLicenseLimitShowPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.CustomerShowPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseIndexPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.PlaylistIndexPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackGenerationIndexPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackGenerationShowPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackIndexPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackShowPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackStoreIndexPublicResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.AccessTokenCustomerServiceIndexResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.AccessTokenCustomerServiceShowJsonConverter),

            typeof(global::Mubert.JsonConverters.CompanyCustomerServiceIndexResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.CompanyCustomerServiceShowJsonConverter),

            typeof(global::Mubert.JsonConverters.CustomerLicenseLimitCustomerServiceIndexResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.CustomerLicenseLimitCustomerServiceShowJsonConverter),

            typeof(global::Mubert.JsonConverters.CustomerCustomerServiceShowResourceResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.LicenseCustomerServiceIndexJsonConverter),

            typeof(global::Mubert.JsonConverters.PlaylistCustomerServiceIndexResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackGenerationCustomerServiceIndexResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackGenerationCustomerServiceShowJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackCustomerServiceIndexResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackCustomerServiceShowJsonConverter),

            typeof(global::Mubert.JsonConverters.TrackStoreCustomerServiceIndexResourceJsonConverter),

            typeof(global::Mubert.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CommentModelTypeEnum), TypeInfoPropertyName = "CommentModelTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanyStatusEnum), TypeInfoPropertyName = "CompanyStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerStatusEnum), TypeInfoPropertyName = "CustomerStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.FeatureEnum), TypeInfoPropertyName = "FeatureEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitResettableFieldEnum), TypeInfoPropertyName = "LicenseLimitResettableFieldEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitStreamingLimitTypeEnum), TypeInfoPropertyName = "LicenseLimitStreamingLimitTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitTracksLimitTypeEnum), TypeInfoPropertyName = "LicenseLimitTracksLimitTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseStatusEnum), TypeInfoPropertyName = "LicenseStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseTypeEnum), TypeInfoPropertyName = "LicenseTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.OrderDirectionEnum), TypeInfoPropertyName = "OrderDirectionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.ReportStatusEnum), TypeInfoPropertyName = "ReportStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.ReportTypeEnum), TypeInfoPropertyName = "ReportTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanySortEnum), TypeInfoPropertyName = "CompanySortEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripeInvoiceBillingReasonEnum), TypeInfoPropertyName = "StripeInvoiceBillingReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripeInvoiceStatusEnum), TypeInfoPropertyName = "StripeInvoiceStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripePaymentIntentStatusEnum), TypeInfoPropertyName = "StripePaymentIntentStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripePriceIntervalEnum), TypeInfoPropertyName = "StripePriceIntervalEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripePriceTypeEnum), TypeInfoPropertyName = "StripePriceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripeSubscriptionStatusEnum), TypeInfoPropertyName = "StripeSubscriptionStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackGenerationStatusEnum), TypeInfoPropertyName = "TrackGenerationStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.UserRoleEnum), TypeInfoPropertyName = "UserRoleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.WebhookStatusEnum), TypeInfoPropertyName = "WebhookStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.AccessTokenExpiredException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.ForbiddenException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.UnauthenticatedException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanyIsNotActiveException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanyNotFoundException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerIsNotActiveException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerNotFoundException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseAlreadyLinkedToSubscriptionException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseExpiredException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseForbiddenBitrateException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseForbiddenDurationException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseForbiddenFeatureException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseForbiddenFormatException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseForbiddenIntensityException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseForbiddenModeException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseIsNotActiveException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseNotFoundException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitConcurrentTrackGenerationsCountException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitStreamingDurationException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitStreamingDurationExceptionType), TypeInfoPropertyName = "LicenseLimitStreamingDurationExceptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitTracksCountException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitTracksCountExceptionType), TypeInfoPropertyName = "LicenseLimitTracksCountExceptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitTracksDurationException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitTracksDurationExceptionType), TypeInfoPropertyName = "LicenseLimitTracksDurationExceptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitUsersCountException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PriceNotFoundException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.RenderApiException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripeCustomerNotFoundException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripeException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripeNeedPlaceOrderException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.FreeSubscriptionCannotBeCancelledException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.SubscriptionIsAlreadyActiveException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.SubscriptionIsNotActiveException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.SubscriptionNotFoundException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackNotFoundException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.UserNotFoundException))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.Error403Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.Error403ResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.Error403ResponseDiscriminatorCode), TypeInfoPropertyName = "Error403ResponseDiscriminatorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.Error404Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.MetadataPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.MetadataPaginationSortable), TypeInfoPropertyName = "MetadataPaginationSortable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.MetadataPaginationSortableVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.AccessTokenPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicensePublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerLicenseLimitPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.AccessTokenIndexPublicResource), TypeInfoPropertyName = "AccessTokenIndexPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.AccessTokenShowPublicResource), TypeInfoPropertyName = "AccessTokenShowPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanyPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanyIndexPublicResource), TypeInfoPropertyName = "CompanyIndexPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanyShowPublicResource), TypeInfoPropertyName = "CompanyShowPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerLicenseLimitIndexPublicResource), TypeInfoPropertyName = "CustomerLicenseLimitIndexPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerLicenseLimitShowPublicResource), TypeInfoPropertyName = "CustomerLicenseLimitShowPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerShowPublicResource), TypeInfoPropertyName = "CustomerShowPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerShowPublicResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.FeatureEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.TrackIntensityEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackIntensityEnum), TypeInfoPropertyName = "TrackIntensityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.TrackFormatEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackFormatEnum), TypeInfoPropertyName = "TrackFormatEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.TrackModeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackModeEnum), TypeInfoPropertyName = "TrackModeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseIndexPublicResource), TypeInfoPropertyName = "LicenseIndexPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PlaylistPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.PlaylistPublicResourceParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PlaylistPublicResourceParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PlaylistPublicResourceParamBpm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.TrackKeyScaleEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackKeyScaleEnum), TypeInfoPropertyName = "TrackKeyScaleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PlaylistIndexPublicResource), TypeInfoPropertyName = "PlaylistIndexPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PriceLimitPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PriceOptionLinkPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PriceOptionPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PriceOptionTranslationPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PricePublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripePricePublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.PriceOptionPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PriceTranslationPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripePricePublicResourceType), TypeInfoPropertyName = "StripePricePublicResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StripePricePublicResourceInterval), TypeInfoPropertyName = "StripePricePublicResourceInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackGenerationPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackGenerationIndexPublicResource), TypeInfoPropertyName = "TrackGenerationIndexPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackGenerationShowPublicResource), TypeInfoPropertyName = "TrackGenerationShowPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackGenerationShowPublicResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackPublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackIndexPublicResource), TypeInfoPropertyName = "TrackIndexPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackIndexPublicResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.TrackGenerationIndexPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackShowPublicResource), TypeInfoPropertyName = "TrackShowPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackShowPublicResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.TrackGenerationShowPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackStorePublicResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackStoreIndexPublicResource), TypeInfoPropertyName = "TrackStoreIndexPublicResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.AccessTokenServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerLicenseLimitServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.AccessTokenCustomerServiceIndexResource), TypeInfoPropertyName = "AccessTokenCustomerServiceIndexResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.AccessTokenCustomerServiceShow), TypeInfoPropertyName = "AccessTokenCustomerServiceShow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanyServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanyCustomerServiceIndexResource), TypeInfoPropertyName = "CompanyCustomerServiceIndexResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CompanyCustomerServiceShow), TypeInfoPropertyName = "CompanyCustomerServiceShow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerLicenseLimitCustomerServiceIndexResource), TypeInfoPropertyName = "CustomerLicenseLimitCustomerServiceIndexResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerLicenseLimitCustomerServiceShow), TypeInfoPropertyName = "CustomerLicenseLimitCustomerServiceShow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerCustomerServiceShowResourceResource), TypeInfoPropertyName = "CustomerCustomerServiceShowResourceResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.CustomerCustomerServiceShowResourceResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseLimitServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LicenseCustomerServiceIndex), TypeInfoPropertyName = "LicenseCustomerServiceIndex2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PlaylistServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PlaylistCustomerServiceIndexResource), TypeInfoPropertyName = "PlaylistCustomerServiceIndexResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackGenerationServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackGenerationCustomerServiceIndexResource), TypeInfoPropertyName = "TrackGenerationCustomerServiceIndexResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackGenerationCustomerServiceShow), TypeInfoPropertyName = "TrackGenerationCustomerServiceShow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackGenerationCustomerServiceShowVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackCustomerServiceIndexResource), TypeInfoPropertyName = "TrackCustomerServiceIndexResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackCustomerServiceIndexResourceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.TrackGenerationCustomerServiceIndexResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackCustomerServiceShow), TypeInfoPropertyName = "TrackCustomerServiceShow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackCustomerServiceShowVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.TrackGenerationCustomerServiceShow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackStoreServiceResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackStoreCustomerServiceIndexResource), TypeInfoPropertyName = "TrackStoreCustomerServiceIndexResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.InstrumentEnum), TypeInfoPropertyName = "InstrumentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StemEnum), TypeInfoPropertyName = "StemEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackKeyEnum), TypeInfoPropertyName = "TrackKeyEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.TrackScaleEnum), TypeInfoPropertyName = "TrackScaleEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.BucketEnum), TypeInfoPropertyName = "BucketEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StreamingLoopStateEnum), TypeInfoPropertyName = "StreamingLoopStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.StreamingTypeEnum), TypeInfoPropertyName = "StreamingTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.LanguageEnum), TypeInfoPropertyName = "LanguageEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicStreamingSetIntensityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicStreamingSetLoopStateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicSubscriptionsBuyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicSubscriptionsBuyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicSubscriptionsCancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicSubscriptionsCancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksByTrackEditRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.StemEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.InstrumentEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksStoredRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksRecordRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksByTrackSimilarRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PutServiceCustomersByCustomerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostServiceCustomersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PutServiceLicensesByLicenseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetServiceStripeBillingPortalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostServiceStripeBillingPortalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetServiceStripeSubscriptionsBuyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostServiceStripeSubscriptionsBuyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetServiceStripeSubscriptionsCancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostServiceStripeSubscriptionsCancelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicMusicLibraryTracksOrder), TypeInfoPropertyName = "GetPublicMusicLibraryTracksOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicTracksOrder), TypeInfoPropertyName = "GetPublicTracksOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.GetPublicMusicLibraryParamsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicMusicLibraryParamsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.GetPublicMusicLibraryParamsResponseItemValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicMusicLibraryParamsResponseItemValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicMusicLibraryTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.TrackIndexPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.PlaylistPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicPricesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.PricePublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicPricesByPriceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicStreamingGetLinkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicStreamingGetLinkResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicStripeWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicSubscriptionsBuyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicSubscriptionsBuyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksByTrackEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksStoredResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksRecordResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicTracksSessionBySessionIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetPublicTracksByTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostPublicTracksByTrackSimilarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetServiceCustomersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.CustomerServiceResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetServiceLicensesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mubert.LicenseServiceResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetServiceStripeBillingPortalResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetServiceStripeBillingPortalResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.GetServiceStripeSubscriptionsBuyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mubert.PostServiceStripeSubscriptionsBuyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.FeatureEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.TrackIntensityEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.TrackFormatEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.TrackModeEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.PlaylistPublicResourceParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.TrackKeyScaleEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.PriceOptionPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.TrackGenerationIndexPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.TrackGenerationShowPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.TrackGenerationCustomerServiceIndexResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.TrackGenerationCustomerServiceShow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.StemEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.InstrumentEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.GetPublicMusicLibraryParamsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.GetPublicMusicLibraryParamsResponseItemValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.TrackIndexPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.PlaylistPublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.PricePublicResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.CustomerServiceResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mubert.LicenseServiceResource>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}