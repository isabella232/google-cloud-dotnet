// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/billing/v1/cloud_catalog.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Billing.V1 {
  /// <summary>
  /// A catalog of Google Cloud Platform services and SKUs.
  /// Provides pricing information and metadata on Google Cloud Platform services
  /// and SKUs.
  /// </summary>
  public static partial class CloudCatalog
  {
    static readonly string __ServiceName = "google.cloud.billing.v1.CloudCatalog";

    static readonly grpc::Marshaller<global::Google.Cloud.Billing.V1.ListServicesRequest> __Marshaller_google_cloud_billing_v1_ListServicesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Billing.V1.ListServicesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Billing.V1.ListServicesResponse> __Marshaller_google_cloud_billing_v1_ListServicesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Billing.V1.ListServicesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Billing.V1.ListSkusRequest> __Marshaller_google_cloud_billing_v1_ListSkusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Billing.V1.ListSkusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Billing.V1.ListSkusResponse> __Marshaller_google_cloud_billing_v1_ListSkusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Billing.V1.ListSkusResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Billing.V1.ListServicesRequest, global::Google.Cloud.Billing.V1.ListServicesResponse> __Method_ListServices = new grpc::Method<global::Google.Cloud.Billing.V1.ListServicesRequest, global::Google.Cloud.Billing.V1.ListServicesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListServices",
        __Marshaller_google_cloud_billing_v1_ListServicesRequest,
        __Marshaller_google_cloud_billing_v1_ListServicesResponse);

    static readonly grpc::Method<global::Google.Cloud.Billing.V1.ListSkusRequest, global::Google.Cloud.Billing.V1.ListSkusResponse> __Method_ListSkus = new grpc::Method<global::Google.Cloud.Billing.V1.ListSkusRequest, global::Google.Cloud.Billing.V1.ListSkusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListSkus",
        __Marshaller_google_cloud_billing_v1_ListSkusRequest,
        __Marshaller_google_cloud_billing_v1_ListSkusResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Billing.V1.CloudCatalogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CloudCatalog</summary>
    [grpc::BindServiceMethod(typeof(CloudCatalog), "BindService")]
    public abstract partial class CloudCatalogBase
    {
      /// <summary>
      /// Lists all public cloud services.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Billing.V1.ListServicesResponse> ListServices(global::Google.Cloud.Billing.V1.ListServicesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists all publicly available SKUs for a given cloud service.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Billing.V1.ListSkusResponse> ListSkus(global::Google.Cloud.Billing.V1.ListSkusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CloudCatalog</summary>
    public partial class CloudCatalogClient : grpc::ClientBase<CloudCatalogClient>
    {
      /// <summary>Creates a new client for CloudCatalog</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CloudCatalogClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CloudCatalog that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CloudCatalogClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CloudCatalogClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CloudCatalogClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists all public cloud services.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Billing.V1.ListServicesResponse ListServices(global::Google.Cloud.Billing.V1.ListServicesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListServices(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all public cloud services.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Billing.V1.ListServicesResponse ListServices(global::Google.Cloud.Billing.V1.ListServicesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListServices, null, options, request);
      }
      /// <summary>
      /// Lists all public cloud services.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Billing.V1.ListServicesResponse> ListServicesAsync(global::Google.Cloud.Billing.V1.ListServicesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListServicesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all public cloud services.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Billing.V1.ListServicesResponse> ListServicesAsync(global::Google.Cloud.Billing.V1.ListServicesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListServices, null, options, request);
      }
      /// <summary>
      /// Lists all publicly available SKUs for a given cloud service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Billing.V1.ListSkusResponse ListSkus(global::Google.Cloud.Billing.V1.ListSkusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListSkus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all publicly available SKUs for a given cloud service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Billing.V1.ListSkusResponse ListSkus(global::Google.Cloud.Billing.V1.ListSkusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListSkus, null, options, request);
      }
      /// <summary>
      /// Lists all publicly available SKUs for a given cloud service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Billing.V1.ListSkusResponse> ListSkusAsync(global::Google.Cloud.Billing.V1.ListSkusRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListSkusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all publicly available SKUs for a given cloud service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Billing.V1.ListSkusResponse> ListSkusAsync(global::Google.Cloud.Billing.V1.ListSkusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListSkus, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CloudCatalogClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CloudCatalogClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CloudCatalogBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListServices, serviceImpl.ListServices)
          .AddMethod(__Method_ListSkus, serviceImpl.ListSkus).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CloudCatalogBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListServices, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Billing.V1.ListServicesRequest, global::Google.Cloud.Billing.V1.ListServicesResponse>(serviceImpl.ListServices));
      serviceBinder.AddMethod(__Method_ListSkus, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Billing.V1.ListSkusRequest, global::Google.Cloud.Billing.V1.ListSkusResponse>(serviceImpl.ListSkus));
    }

  }
}
#endregion
