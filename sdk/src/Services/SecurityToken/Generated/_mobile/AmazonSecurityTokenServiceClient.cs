/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SecurityToken.Model;
using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using Amazon.SecurityToken.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken
{
    /// <summary>
    /// Implementation for accessing SecurityTokenService
    ///
    /// AWS Security Token Service 
    /// <para>
    /// The AWS Security Token Service (STS) is a web service that enables you to request
    /// temporary, limited-privilege credentials for AWS Identity and Access Management (IAM)
    /// users or for users that you authenticate (federated users). This guide provides descriptions
    /// of the STS API. For more detailed information about using this service, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  As an alternative to using the API, you can use one of the AWS SDKs, which consist
    /// of libraries and sample code for various programming languages and platforms (Java,
    /// Ruby, .NET, iOS, Android, etc.). The SDKs provide a convenient way to create programmatic
    /// access to STS. For example, the SDKs take care of cryptographically signing requests,
    /// managing errors, and retrying requests automatically. For information about the AWS
    /// SDKs, including how to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services page</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about setting up signatures and authorization through the API, go
    /// to <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
    /// about the Query API, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in <i>Using IAM</i>. For information about using security tokens
    /// with other AWS products, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-services-that-work-with-iam.html">AWS
    /// Services That Work with IAM</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// If you're new to AWS and need additional technical information about a specific AWS
    /// product, you can find the product's technical documentation at <a href="http://aws.amazon.com/documentation/">http://aws.amazon.com/documentation/</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// By default, AWS Security Token Service (STS) is available as a global service, and
    /// all AWS STS requests go to a single endpoint at <code>https://sts.amazonaws.com</code>.
    /// Global requests map to the US East (N. Virginia) region. AWS recommends using Regional
    /// AWS STS endpoints instead of the global endpoint to reduce latency, build in redundancy,
    /// and increase session token validity. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Managing
    /// AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Most AWS Regions are enabled for operations in all AWS services by default. Those
    /// Regions are automatically activated for use with AWS STS. Some Regions, such as Asia
    /// Pacific (Hong Kong), must be manually enabled. To learn more about enabling and disabling
    /// AWS Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
    /// AWS Regions</a> in the <i>AWS General Reference</i>. When you enable these AWS Regions,
    /// they are automatically activated for use with AWS STS. You cannot activate the STS
    /// endpoint for a Region that is disabled. Tokens that are valid in all AWS Regions are
    /// longer than tokens that are valid in Regions that are enabled by default. Changing
    /// this setting might affect existing systems where you temporarily store tokens. For
    /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html#sts-regions-manage-tokens">Managing
    /// Global Endpoint Session Tokens</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// After you activate a Region for use with AWS STS, you can direct AWS STS API calls
    /// to that Region. AWS STS recommends that you use both the <code>setRegion</code> and
    /// <code>setEndpoint</code> methods to make calls to a Regional endpoint. You can use
    /// the <code>setRegion</code> method alone for manually enabled Regions, such as Asia
    /// Pacific (Hong Kong). In this case, the calls are directed to the STS Regional endpoint.
    /// However, if you use the <code>setRegion</code> method alone for Regions enabled by
    /// default, the calls are directed to the global endpoint of <code>https://sts.amazonaws.com</code>.
    /// </para>
    ///  
    /// <para>
    /// To view the list of AWS STS endpoints and whether they are active by default, see
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html#id_credentials_temp_enable-regions_writing_code">Writing
    /// Code to Use AWS STS Regions</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API requests</b> 
    /// </para>
    ///  
    /// <para>
    /// STS supports AWS CloudTrail, which is a service that records AWS calls for your AWS
    /// account and delivers log files to an Amazon S3 bucket. By using information collected
    /// by CloudTrail, you can determine what requests were successfully made to STS, who
    /// made the request, when it was made, and so on.
    /// </para>
    ///  
    /// <para>
    /// If you activate AWS STS endpoints in Regions other than the default global endpoint,
    /// then you must also turn on CloudTrail logging in those Regions. This is necessary
    /// to record any AWS STS API calls that are made in those Regions. For more information,
    /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/aggregating_logs_regions_turn_on_ct.html">Turning
    /// On CloudTrail in Additional Regions</a> in the <i>AWS CloudTrail User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// AWS Security Token Service (STS) is a global service with a single endpoint at <code>https://sts.amazonaws.com</code>.
    /// Calls to this endpoint are logged as calls to a global service. However, because this
    /// endpoint is physically located in the US East (N. Virginia) Region, your logs list
    /// <code>us-east-1</code> as the event Region. CloudTrail does not write these logs to
    /// the US East (Ohio) Region unless you choose to include global service logs in that
    /// Region. CloudTrail writes calls to all Regional endpoints to their respective Regions.
    /// For example, calls to sts.us-east-2.amazonaws.com are published to the US East (Ohio)
    /// Region and calls to sts.eu-central-1.amazonaws.com are published to the EU (Frankfurt)
    /// Region.
    /// </para>
    ///  
    /// <para>
    /// To learn more about CloudTrail, including how to turn it on and find your log files,
    /// see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">AWS
    /// CloudTrail User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonSecurityTokenServiceClient : AmazonServiceClient, IAmazonSecurityTokenService
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityTokenServiceMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSecurityTokenServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityTokenServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityTokenServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AmazonSecurityTokenServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecurityTokenServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials and an
        /// AmazonSecurityTokenServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityTokenServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityTokenServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityTokenServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssumeRole

        internal virtual AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRole">REST API Reference for AssumeRole Operation</seealso>
        public virtual Task<AssumeRoleResponse> AssumeRoleAsync(AssumeRoleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleResponseUnmarshaller.Instance;

            return InvokeAsync<AssumeRoleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssumeRoleWithSAML

        internal virtual AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithSAMLResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleWithSAMLResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithSAML operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithSAML">REST API Reference for AssumeRoleWithSAML Operation</seealso>
        public virtual Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithSAMLResponseUnmarshaller.Instance;

            return InvokeAsync<AssumeRoleWithSAMLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssumeRoleWithWebIdentity

        internal virtual AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithWebIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithWebIdentityResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleWithWebIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithWebIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithWebIdentity">REST API Reference for AssumeRoleWithWebIdentity Operation</seealso>
        public virtual Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithWebIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithWebIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<AssumeRoleWithWebIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DecodeAuthorizationMessage

        internal virtual DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecodeAuthorizationMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecodeAuthorizationMessageResponseUnmarshaller.Instance;

            return Invoke<DecodeAuthorizationMessageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DecodeAuthorizationMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecodeAuthorizationMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/DecodeAuthorizationMessage">REST API Reference for DecodeAuthorizationMessage Operation</seealso>
        public virtual Task<DecodeAuthorizationMessageResponse> DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecodeAuthorizationMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecodeAuthorizationMessageResponseUnmarshaller.Instance;

            return InvokeAsync<DecodeAuthorizationMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCallerIdentity

        internal virtual GetCallerIdentityResponse GetCallerIdentity(GetCallerIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallerIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallerIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCallerIdentityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCallerIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCallerIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetCallerIdentity">REST API Reference for GetCallerIdentity Operation</seealso>
        public virtual Task<GetCallerIdentityResponse> GetCallerIdentityAsync(GetCallerIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallerIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallerIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<GetCallerIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFederationToken

        internal virtual GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFederationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFederationTokenResponseUnmarshaller.Instance;

            return Invoke<GetFederationTokenResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFederationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        public virtual Task<GetFederationTokenResponse> GetFederationTokenAsync(GetFederationTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFederationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFederationTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetFederationTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSessionToken

        internal virtual GetSessionTokenResponse GetSessionToken()
        {
            return GetSessionToken(new GetSessionTokenRequest());
        }
        internal virtual GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionTokenResponseUnmarshaller.Instance;

            return Invoke<GetSessionTokenResponse>(request, options);
        }


        /// <summary>
        /// Returns a set of temporary credentials for an AWS account or IAM user. The credentials
        /// consist of an access key ID, a secret access key, and a security token. Typically,
        /// you use <code>GetSessionToken</code> if you want to use MFA to protect programmatic
        /// calls to specific AWS API operations like Amazon EC2 <code>StopInstances</code>. MFA-enabled
        /// IAM users would need to call <code>GetSessionToken</code> and submit an MFA code that
        /// is associated with their MFA device. Using the temporary security credentials that
        /// are returned from the call, IAM users can then make programmatic calls to API operations
        /// that require MFA authentication. If you do not supply a correct MFA code, then the
        /// API returns an access denied error. For a comparison of <code>GetSessionToken</code>
        /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The <code>GetSessionToken</code> operation must be called by using the long-term AWS
        /// security credentials of the AWS account root user or an IAM user. Credentials that
        /// are created by IAM users are valid for the duration that you specify. This duration
        /// can range from 900 seconds (15 minutes) up to a maximum of 129,600 seconds (36 hours),
        /// with a default of 43,200 seconds (12 hours). Credentials based on account credentials
        /// can range from 900 seconds (15 minutes) up to 3,600 seconds (1 hour), with a default
        /// of 1 hour. 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>GetSessionToken</code> can be
        /// used to make API calls to any AWS service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot call any IAM API operations unless MFA authentication information is included
        /// in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS API <i>except</i> <code>AssumeRole</code> or <code>GetCallerIdentity</code>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// We recommend that you do not call <code>GetSessionToken</code> with AWS account root
        /// user credentials. Instead, follow our <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#create-iam-users">best
        /// practices</a> by creating one or more IAM users, giving them the necessary permissions,
        /// and using IAM users for everyday interaction with AWS. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The credentials that are returned by <code>GetSessionToken</code> are based on permissions
        /// associated with the user whose credentials were used to call the operation. If <code>GetSessionToken</code>
        /// is called using AWS account root user credentials, the temporary credentials have
        /// root user permissions. Similarly, if <code>GetSessionToken</code> is called using
        /// the credentials of an IAM user, the temporary credentials have the same permissions
        /// as the IAM user. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using <code>GetSessionToken</code> to create temporary
        /// credentials, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getsessiontoken">Temporary
        /// Credentials for Users in Untrusted Environments</a> in the <i>IAM User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        public virtual Task<GetSessionTokenResponse> GetSessionTokenAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetSessionTokenAsync(new GetSessionTokenRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        public virtual Task<GetSessionTokenResponse> GetSessionTokenAsync(GetSessionTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionTokenResponseUnmarshaller.Instance;

            return InvokeAsync<GetSessionTokenResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}