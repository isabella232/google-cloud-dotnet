// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gcsv = Google.Cloud.SecurityCenter.V1P1Beta1;
using sys = System;

namespace Google.Cloud.SecurityCenter.V1P1Beta1
{
    /// <summary>Resource name for the <c>NotificationConfig</c> resource.</summary>
    public sealed partial class NotificationConfigName : gax::IResourceName, sys::IEquatable<NotificationConfigName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("organizations/{organization}/notificationConfigs/{notification_config}");

        /// <summary>
        /// Parses the given <c>NotificationConfig</c> resource name in string form into a new
        /// <see cref="NotificationConfigName"/> instance.
        /// </summary>
        /// <param name="notificationConfigName">
        /// The <c>NotificationConfig</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="NotificationConfigName"/> if successful.</returns>
        public static NotificationConfigName Parse(string notificationConfigName)
        {
            gax::GaxPreconditions.CheckNotNull(notificationConfigName, nameof(notificationConfigName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(notificationConfigName);
            return new NotificationConfigName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new
        /// <see cref="NotificationConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if
        /// <paramref name="notificationConfigName"/> is <c>null</c>, as this would usually indicate a programming error
        /// rather than a data error.
        /// </remarks>
        /// <param name="notificationConfigName">
        /// The <c>NotificationConfig</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotificationConfigName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationConfigName, out NotificationConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(notificationConfigName, nameof(notificationConfigName));
            if (s_template.TryParseName(notificationConfigName, out gax::TemplatedResourceName resourceName))
            {
                result = new NotificationConfigName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Formats the IDs into the string representation of the <see cref="NotificationConfigName"/>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="notificationConfigId">The <c>NotificationConfig</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="NotificationConfigName"/>.</returns>
        public static string Format(string organizationId, string notificationConfigId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNull(notificationConfigId, nameof(notificationConfigId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="NotificationConfigName"/> resource name class from its component
        /// parts.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c>.</param>
        /// <param name="notificationConfigId">The <c>NotificationConfig</c> ID. Must not be <c>null</c>.</param>
        public NotificationConfigName(string organizationId, string notificationConfigId)
        {
            OrganizationId = gax::GaxPreconditions.CheckNotNull(organizationId, nameof(organizationId));
            NotificationConfigId = gax::GaxPreconditions.CheckNotNull(notificationConfigId, nameof(notificationConfigId));
        }

        /// <summary>The <c>Organization</c> ID. Never <c>null</c>.</summary>
        public string OrganizationId { get; }

        /// <summary>The <c>NotificationConfig</c> ID. Never <c>null</c>.</summary>
        public string NotificationConfigId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(OrganizationId, NotificationConfigId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NotificationConfigName);

        /// <inheritdoc/>
        public bool Equals(NotificationConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(NotificationConfigName a, NotificationConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(NotificationConfigName a, NotificationConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Topic</c> resource.</summary>
    public sealed partial class TopicName : gax::IResourceName, sys::IEquatable<TopicName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>
        /// Parses the given <c>Topic</c> resource name in string form into a new <see cref="TopicName"/> instance.
        /// </summary>
        /// <param name="topicName">The <c>Topic</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicName"/> if successful.</returns>
        public static TopicName Parse(string topicName)
        {
            gax::GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(topicName);
            return new TopicName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="TopicName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="topicName"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="topicName">The <c>Topic</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicName, out TopicName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicName, nameof(topicName));
            if (s_template.TryParseName(topicName, out gax::TemplatedResourceName resourceName))
            {
                result = new TopicName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="TopicName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="TopicName"/>.</returns>
        public static string Format(string projectId, string topicId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(topicId, nameof(topicId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="TopicName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="topicId">The <c>Topic</c> ID. Must not be <c>null</c>.</param>
        public TopicName(string projectId, string topicId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            TopicId = gax::GaxPreconditions.CheckNotNull(topicId, nameof(topicId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Topic</c> ID. Never <c>null</c>.</summary>
        public string TopicId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, TopicId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TopicName);

        /// <inheritdoc/>
        public bool Equals(TopicName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(TopicName a, TopicName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(TopicName a, TopicName b) => !(a == b);
    }

    public partial class NotificationConfig
    {
        /// <summary>
        /// <see cref="gcsv::NotificationConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::NotificationConfigName NotificationConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::NotificationConfigName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TopicName"/>-typed view over the <see cref="PubsubTopic"/> resource name property.
        /// </summary>
        public TopicName PubsubTopicAsTopicName
        {
            get => string.IsNullOrEmpty(PubsubTopic) ? null : TopicName.Parse(PubsubTopic);
            set => PubsubTopic = value?.ToString() ?? "";
        }
    }
}
