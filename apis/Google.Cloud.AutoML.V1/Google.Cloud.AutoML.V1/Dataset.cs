// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/dataset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/dataset.proto</summary>
  public static partial class DatasetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/dataset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DatasetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRnb29nbGUvY2xvdWQvYXV0b21sL3YxL2RhdGFzZXQucHJvdG8SFmdvb2ds",
            "ZS5jbG91ZC5hdXRvbWwudjEaGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8a",
            "Imdvb2dsZS9jbG91ZC9hdXRvbWwvdjEvaW1hZ2UucHJvdG8aIWdvb2dsZS9j",
            "bG91ZC9hdXRvbWwvdjEvdGV4dC5wcm90bxooZ29vZ2xlL2Nsb3VkL2F1dG9t",
            "bC92MS90cmFuc2xhdGlvbi5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVz",
            "dGFtcC5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLgBwoH",
            "RGF0YXNldBJaChx0cmFuc2xhdGlvbl9kYXRhc2V0X21ldGFkYXRhGBcgASgL",
            "MjIuZ29vZ2xlLmNsb3VkLmF1dG9tbC52MS5UcmFuc2xhdGlvbkRhdGFzZXRN",
            "ZXRhZGF0YUgAEmsKJWltYWdlX2NsYXNzaWZpY2F0aW9uX2RhdGFzZXRfbWV0",
            "YWRhdGEYGCABKAsyOi5nb29nbGUuY2xvdWQuYXV0b21sLnYxLkltYWdlQ2xh",
            "c3NpZmljYXRpb25EYXRhc2V0TWV0YWRhdGFIABJpCiR0ZXh0X2NsYXNzaWZp",
            "Y2F0aW9uX2RhdGFzZXRfbWV0YWRhdGEYGSABKAsyOS5nb29nbGUuY2xvdWQu",
            "YXV0b21sLnYxLlRleHRDbGFzc2lmaWNhdGlvbkRhdGFzZXRNZXRhZGF0YUgA",
            "Em4KJ2ltYWdlX29iamVjdF9kZXRlY3Rpb25fZGF0YXNldF9tZXRhZGF0YRga",
            "IAEoCzI7Lmdvb2dsZS5jbG91ZC5hdXRvbWwudjEuSW1hZ2VPYmplY3REZXRl",
            "Y3Rpb25EYXRhc2V0TWV0YWRhdGFIABJhCiB0ZXh0X2V4dHJhY3Rpb25fZGF0",
            "YXNldF9tZXRhZGF0YRgcIAEoCzI1Lmdvb2dsZS5jbG91ZC5hdXRvbWwudjEu",
            "VGV4dEV4dHJhY3Rpb25EYXRhc2V0TWV0YWRhdGFIABJfCh90ZXh0X3NlbnRp",
            "bWVudF9kYXRhc2V0X21ldGFkYXRhGB4gASgLMjQuZ29vZ2xlLmNsb3VkLmF1",
            "dG9tbC52MS5UZXh0U2VudGltZW50RGF0YXNldE1ldGFkYXRhSAASDAoEbmFt",
            "ZRgBIAEoCRIUCgxkaXNwbGF5X25hbWUYAiABKAkSEwoLZGVzY3JpcHRpb24Y",
            "AyABKAkSFQoNZXhhbXBsZV9jb3VudBgVIAEoBRIvCgtjcmVhdGVfdGltZRgO",
            "IAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASDAoEZXRhZxgRIAEo",
            "CRI7CgZsYWJlbHMYJyADKAsyKy5nb29nbGUuY2xvdWQuYXV0b21sLnYxLkRh",
            "dGFzZXQuTGFiZWxzRW50cnkaLQoLTGFiZWxzRW50cnkSCwoDa2V5GAEgASgJ",
            "Eg0KBXZhbHVlGAIgASgJOgI4ATpe6kFbCh1hdXRvbWwuZ29vZ2xlYXBpcy5j",
            "b20vRGF0YXNldBI6cHJvamVjdHMve3Byb2plY3R9L2xvY2F0aW9ucy97bG9j",
            "YXRpb259L2RhdGFzZXRzL3tkYXRhc2V0fUISChBkYXRhc2V0X21ldGFkYXRh",
            "QqoBChpjb20uZ29vZ2xlLmNsb3VkLmF1dG9tbC52MVABWjxnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL2F1dG9tbC92MTth",
            "dXRvbWyqAhZHb29nbGUuQ2xvdWQuQXV0b01MLlYxygIWR29vZ2xlXENsb3Vk",
            "XEF1dG9NbFxWMeoCGUdvb2dsZTo6Q2xvdWQ6OkF1dG9NTDo6VjFiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.AutoML.V1.ImageReflection.Descriptor, global::Google.Cloud.AutoML.V1.TextReflection.Descriptor, global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.Dataset), global::Google.Cloud.AutoML.V1.Dataset.Parser, new[]{ "TranslationDatasetMetadata", "ImageClassificationDatasetMetadata", "TextClassificationDatasetMetadata", "ImageObjectDetectionDatasetMetadata", "TextExtractionDatasetMetadata", "TextSentimentDatasetMetadata", "Name", "DisplayName", "Description", "ExampleCount", "CreateTime", "Etag", "Labels" }, new[]{ "DatasetMetadata" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A workspace for solving a single, particular machine learning (ML) problem.
  /// A workspace contains examples that may be annotated.
  /// </summary>
  public sealed partial class Dataset : pb::IMessage<Dataset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Dataset> _parser = new pb::MessageParser<Dataset>(() => new Dataset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Dataset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.DatasetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Dataset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Dataset(Dataset other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      exampleCount_ = other.exampleCount_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      etag_ = other.etag_;
      labels_ = other.labels_.Clone();
      switch (other.DatasetMetadataCase) {
        case DatasetMetadataOneofCase.TranslationDatasetMetadata:
          TranslationDatasetMetadata = other.TranslationDatasetMetadata.Clone();
          break;
        case DatasetMetadataOneofCase.ImageClassificationDatasetMetadata:
          ImageClassificationDatasetMetadata = other.ImageClassificationDatasetMetadata.Clone();
          break;
        case DatasetMetadataOneofCase.TextClassificationDatasetMetadata:
          TextClassificationDatasetMetadata = other.TextClassificationDatasetMetadata.Clone();
          break;
        case DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata:
          ImageObjectDetectionDatasetMetadata = other.ImageObjectDetectionDatasetMetadata.Clone();
          break;
        case DatasetMetadataOneofCase.TextExtractionDatasetMetadata:
          TextExtractionDatasetMetadata = other.TextExtractionDatasetMetadata.Clone();
          break;
        case DatasetMetadataOneofCase.TextSentimentDatasetMetadata:
          TextSentimentDatasetMetadata = other.TextSentimentDatasetMetadata.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Dataset Clone() {
      return new Dataset(this);
    }

    /// <summary>Field number for the "translation_dataset_metadata" field.</summary>
    public const int TranslationDatasetMetadataFieldNumber = 23;
    /// <summary>
    /// Metadata for a dataset used for translation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata TranslationDatasetMetadata {
      get { return datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata ? (global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata) datasetMetadata_ : null; }
      set {
        datasetMetadata_ = value;
        datasetMetadataCase_ = value == null ? DatasetMetadataOneofCase.None : DatasetMetadataOneofCase.TranslationDatasetMetadata;
      }
    }

    /// <summary>Field number for the "image_classification_dataset_metadata" field.</summary>
    public const int ImageClassificationDatasetMetadataFieldNumber = 24;
    /// <summary>
    /// Metadata for a dataset used for image classification.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.ImageClassificationDatasetMetadata ImageClassificationDatasetMetadata {
      get { return datasetMetadataCase_ == DatasetMetadataOneofCase.ImageClassificationDatasetMetadata ? (global::Google.Cloud.AutoML.V1.ImageClassificationDatasetMetadata) datasetMetadata_ : null; }
      set {
        datasetMetadata_ = value;
        datasetMetadataCase_ = value == null ? DatasetMetadataOneofCase.None : DatasetMetadataOneofCase.ImageClassificationDatasetMetadata;
      }
    }

    /// <summary>Field number for the "text_classification_dataset_metadata" field.</summary>
    public const int TextClassificationDatasetMetadataFieldNumber = 25;
    /// <summary>
    /// Metadata for a dataset used for text classification.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TextClassificationDatasetMetadata TextClassificationDatasetMetadata {
      get { return datasetMetadataCase_ == DatasetMetadataOneofCase.TextClassificationDatasetMetadata ? (global::Google.Cloud.AutoML.V1.TextClassificationDatasetMetadata) datasetMetadata_ : null; }
      set {
        datasetMetadata_ = value;
        datasetMetadataCase_ = value == null ? DatasetMetadataOneofCase.None : DatasetMetadataOneofCase.TextClassificationDatasetMetadata;
      }
    }

    /// <summary>Field number for the "image_object_detection_dataset_metadata" field.</summary>
    public const int ImageObjectDetectionDatasetMetadataFieldNumber = 26;
    /// <summary>
    /// Metadata for a dataset used for image object detection.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.ImageObjectDetectionDatasetMetadata ImageObjectDetectionDatasetMetadata {
      get { return datasetMetadataCase_ == DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata ? (global::Google.Cloud.AutoML.V1.ImageObjectDetectionDatasetMetadata) datasetMetadata_ : null; }
      set {
        datasetMetadata_ = value;
        datasetMetadataCase_ = value == null ? DatasetMetadataOneofCase.None : DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata;
      }
    }

    /// <summary>Field number for the "text_extraction_dataset_metadata" field.</summary>
    public const int TextExtractionDatasetMetadataFieldNumber = 28;
    /// <summary>
    /// Metadata for a dataset used for text extraction.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TextExtractionDatasetMetadata TextExtractionDatasetMetadata {
      get { return datasetMetadataCase_ == DatasetMetadataOneofCase.TextExtractionDatasetMetadata ? (global::Google.Cloud.AutoML.V1.TextExtractionDatasetMetadata) datasetMetadata_ : null; }
      set {
        datasetMetadata_ = value;
        datasetMetadataCase_ = value == null ? DatasetMetadataOneofCase.None : DatasetMetadataOneofCase.TextExtractionDatasetMetadata;
      }
    }

    /// <summary>Field number for the "text_sentiment_dataset_metadata" field.</summary>
    public const int TextSentimentDatasetMetadataFieldNumber = 30;
    /// <summary>
    /// Metadata for a dataset used for text sentiment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TextSentimentDatasetMetadata TextSentimentDatasetMetadata {
      get { return datasetMetadataCase_ == DatasetMetadataOneofCase.TextSentimentDatasetMetadata ? (global::Google.Cloud.AutoML.V1.TextSentimentDatasetMetadata) datasetMetadata_ : null; }
      set {
        datasetMetadata_ = value;
        datasetMetadataCase_ = value == null ? DatasetMetadataOneofCase.None : DatasetMetadataOneofCase.TextSentimentDatasetMetadata;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The resource name of the dataset.
    /// Form: `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. The name of the dataset to show in the interface. The name can be
    /// up to 32 characters long and can consist only of ASCII Latin letters A-Z
    /// and a-z, underscores
    /// (_), and ASCII digits 0-9.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// User-provided description of the dataset. The description can be up to
    /// 25000 characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "example_count" field.</summary>
    public const int ExampleCountFieldNumber = 21;
    private int exampleCount_;
    /// <summary>
    /// Output only. The number of examples in the dataset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ExampleCount {
      get { return exampleCount_; }
      set {
        exampleCount_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 14;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when this dataset was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 17;
    private string etag_ = "";
    /// <summary>
    /// Used to perform consistent read-modify-write updates. If not set, a blind
    /// "overwrite" update happens.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 39;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 314);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. The labels with user-defined metadata to organize your dataset.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// Label values are optional. Label keys must start with a letter.
    ///
    /// See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    private object datasetMetadata_;
    /// <summary>Enum of possible cases for the "dataset_metadata" oneof.</summary>
    public enum DatasetMetadataOneofCase {
      None = 0,
      TranslationDatasetMetadata = 23,
      ImageClassificationDatasetMetadata = 24,
      TextClassificationDatasetMetadata = 25,
      ImageObjectDetectionDatasetMetadata = 26,
      TextExtractionDatasetMetadata = 28,
      TextSentimentDatasetMetadata = 30,
    }
    private DatasetMetadataOneofCase datasetMetadataCase_ = DatasetMetadataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DatasetMetadataOneofCase DatasetMetadataCase {
      get { return datasetMetadataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearDatasetMetadata() {
      datasetMetadataCase_ = DatasetMetadataOneofCase.None;
      datasetMetadata_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Dataset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Dataset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TranslationDatasetMetadata, other.TranslationDatasetMetadata)) return false;
      if (!object.Equals(ImageClassificationDatasetMetadata, other.ImageClassificationDatasetMetadata)) return false;
      if (!object.Equals(TextClassificationDatasetMetadata, other.TextClassificationDatasetMetadata)) return false;
      if (!object.Equals(ImageObjectDetectionDatasetMetadata, other.ImageObjectDetectionDatasetMetadata)) return false;
      if (!object.Equals(TextExtractionDatasetMetadata, other.TextExtractionDatasetMetadata)) return false;
      if (!object.Equals(TextSentimentDatasetMetadata, other.TextSentimentDatasetMetadata)) return false;
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (ExampleCount != other.ExampleCount) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (Etag != other.Etag) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (DatasetMetadataCase != other.DatasetMetadataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) hash ^= TranslationDatasetMetadata.GetHashCode();
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageClassificationDatasetMetadata) hash ^= ImageClassificationDatasetMetadata.GetHashCode();
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextClassificationDatasetMetadata) hash ^= TextClassificationDatasetMetadata.GetHashCode();
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata) hash ^= ImageObjectDetectionDatasetMetadata.GetHashCode();
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextExtractionDatasetMetadata) hash ^= TextExtractionDatasetMetadata.GetHashCode();
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextSentimentDatasetMetadata) hash ^= TextSentimentDatasetMetadata.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (ExampleCount != 0) hash ^= ExampleCount.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      hash ^= Labels.GetHashCode();
      hash ^= (int) datasetMetadataCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (createTime_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(CreateTime);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(Etag);
      }
      if (ExampleCount != 0) {
        output.WriteRawTag(168, 1);
        output.WriteInt32(ExampleCount);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) {
        output.WriteRawTag(186, 1);
        output.WriteMessage(TranslationDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageClassificationDatasetMetadata) {
        output.WriteRawTag(194, 1);
        output.WriteMessage(ImageClassificationDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextClassificationDatasetMetadata) {
        output.WriteRawTag(202, 1);
        output.WriteMessage(TextClassificationDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata) {
        output.WriteRawTag(210, 1);
        output.WriteMessage(ImageObjectDetectionDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextExtractionDatasetMetadata) {
        output.WriteRawTag(226, 1);
        output.WriteMessage(TextExtractionDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextSentimentDatasetMetadata) {
        output.WriteRawTag(242, 1);
        output.WriteMessage(TextSentimentDatasetMetadata);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (createTime_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(CreateTime);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(Etag);
      }
      if (ExampleCount != 0) {
        output.WriteRawTag(168, 1);
        output.WriteInt32(ExampleCount);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) {
        output.WriteRawTag(186, 1);
        output.WriteMessage(TranslationDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageClassificationDatasetMetadata) {
        output.WriteRawTag(194, 1);
        output.WriteMessage(ImageClassificationDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextClassificationDatasetMetadata) {
        output.WriteRawTag(202, 1);
        output.WriteMessage(TextClassificationDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata) {
        output.WriteRawTag(210, 1);
        output.WriteMessage(ImageObjectDetectionDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextExtractionDatasetMetadata) {
        output.WriteRawTag(226, 1);
        output.WriteMessage(TextExtractionDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextSentimentDatasetMetadata) {
        output.WriteRawTag(242, 1);
        output.WriteMessage(TextSentimentDatasetMetadata);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TranslationDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageClassificationDatasetMetadata) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ImageClassificationDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextClassificationDatasetMetadata) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TextClassificationDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ImageObjectDetectionDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextExtractionDatasetMetadata) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TextExtractionDatasetMetadata);
      }
      if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextSentimentDatasetMetadata) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TextSentimentDatasetMetadata);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (ExampleCount != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(ExampleCount);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (Etag.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Dataset other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.ExampleCount != 0) {
        ExampleCount = other.ExampleCount;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      labels_.Add(other.labels_);
      switch (other.DatasetMetadataCase) {
        case DatasetMetadataOneofCase.TranslationDatasetMetadata:
          if (TranslationDatasetMetadata == null) {
            TranslationDatasetMetadata = new global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata();
          }
          TranslationDatasetMetadata.MergeFrom(other.TranslationDatasetMetadata);
          break;
        case DatasetMetadataOneofCase.ImageClassificationDatasetMetadata:
          if (ImageClassificationDatasetMetadata == null) {
            ImageClassificationDatasetMetadata = new global::Google.Cloud.AutoML.V1.ImageClassificationDatasetMetadata();
          }
          ImageClassificationDatasetMetadata.MergeFrom(other.ImageClassificationDatasetMetadata);
          break;
        case DatasetMetadataOneofCase.TextClassificationDatasetMetadata:
          if (TextClassificationDatasetMetadata == null) {
            TextClassificationDatasetMetadata = new global::Google.Cloud.AutoML.V1.TextClassificationDatasetMetadata();
          }
          TextClassificationDatasetMetadata.MergeFrom(other.TextClassificationDatasetMetadata);
          break;
        case DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata:
          if (ImageObjectDetectionDatasetMetadata == null) {
            ImageObjectDetectionDatasetMetadata = new global::Google.Cloud.AutoML.V1.ImageObjectDetectionDatasetMetadata();
          }
          ImageObjectDetectionDatasetMetadata.MergeFrom(other.ImageObjectDetectionDatasetMetadata);
          break;
        case DatasetMetadataOneofCase.TextExtractionDatasetMetadata:
          if (TextExtractionDatasetMetadata == null) {
            TextExtractionDatasetMetadata = new global::Google.Cloud.AutoML.V1.TextExtractionDatasetMetadata();
          }
          TextExtractionDatasetMetadata.MergeFrom(other.TextExtractionDatasetMetadata);
          break;
        case DatasetMetadataOneofCase.TextSentimentDatasetMetadata:
          if (TextSentimentDatasetMetadata == null) {
            TextSentimentDatasetMetadata = new global::Google.Cloud.AutoML.V1.TextSentimentDatasetMetadata();
          }
          TextSentimentDatasetMetadata.MergeFrom(other.TextSentimentDatasetMetadata);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 114: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 138: {
            Etag = input.ReadString();
            break;
          }
          case 168: {
            ExampleCount = input.ReadInt32();
            break;
          }
          case 186: {
            global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) {
              subBuilder.MergeFrom(TranslationDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            TranslationDatasetMetadata = subBuilder;
            break;
          }
          case 194: {
            global::Google.Cloud.AutoML.V1.ImageClassificationDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.ImageClassificationDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageClassificationDatasetMetadata) {
              subBuilder.MergeFrom(ImageClassificationDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            ImageClassificationDatasetMetadata = subBuilder;
            break;
          }
          case 202: {
            global::Google.Cloud.AutoML.V1.TextClassificationDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.TextClassificationDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextClassificationDatasetMetadata) {
              subBuilder.MergeFrom(TextClassificationDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            TextClassificationDatasetMetadata = subBuilder;
            break;
          }
          case 210: {
            global::Google.Cloud.AutoML.V1.ImageObjectDetectionDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.ImageObjectDetectionDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata) {
              subBuilder.MergeFrom(ImageObjectDetectionDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            ImageObjectDetectionDatasetMetadata = subBuilder;
            break;
          }
          case 226: {
            global::Google.Cloud.AutoML.V1.TextExtractionDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.TextExtractionDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextExtractionDatasetMetadata) {
              subBuilder.MergeFrom(TextExtractionDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            TextExtractionDatasetMetadata = subBuilder;
            break;
          }
          case 242: {
            global::Google.Cloud.AutoML.V1.TextSentimentDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.TextSentimentDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextSentimentDatasetMetadata) {
              subBuilder.MergeFrom(TextSentimentDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            TextSentimentDatasetMetadata = subBuilder;
            break;
          }
          case 314: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 114: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 138: {
            Etag = input.ReadString();
            break;
          }
          case 168: {
            ExampleCount = input.ReadInt32();
            break;
          }
          case 186: {
            global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.TranslationDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.TranslationDatasetMetadata) {
              subBuilder.MergeFrom(TranslationDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            TranslationDatasetMetadata = subBuilder;
            break;
          }
          case 194: {
            global::Google.Cloud.AutoML.V1.ImageClassificationDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.ImageClassificationDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageClassificationDatasetMetadata) {
              subBuilder.MergeFrom(ImageClassificationDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            ImageClassificationDatasetMetadata = subBuilder;
            break;
          }
          case 202: {
            global::Google.Cloud.AutoML.V1.TextClassificationDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.TextClassificationDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextClassificationDatasetMetadata) {
              subBuilder.MergeFrom(TextClassificationDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            TextClassificationDatasetMetadata = subBuilder;
            break;
          }
          case 210: {
            global::Google.Cloud.AutoML.V1.ImageObjectDetectionDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.ImageObjectDetectionDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.ImageObjectDetectionDatasetMetadata) {
              subBuilder.MergeFrom(ImageObjectDetectionDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            ImageObjectDetectionDatasetMetadata = subBuilder;
            break;
          }
          case 226: {
            global::Google.Cloud.AutoML.V1.TextExtractionDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.TextExtractionDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextExtractionDatasetMetadata) {
              subBuilder.MergeFrom(TextExtractionDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            TextExtractionDatasetMetadata = subBuilder;
            break;
          }
          case 242: {
            global::Google.Cloud.AutoML.V1.TextSentimentDatasetMetadata subBuilder = new global::Google.Cloud.AutoML.V1.TextSentimentDatasetMetadata();
            if (datasetMetadataCase_ == DatasetMetadataOneofCase.TextSentimentDatasetMetadata) {
              subBuilder.MergeFrom(TextSentimentDatasetMetadata);
            }
            input.ReadMessage(subBuilder);
            TextSentimentDatasetMetadata = subBuilder;
            break;
          }
          case 314: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
