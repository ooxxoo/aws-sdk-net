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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RedshiftSettings
    {
        private bool? _acceptAnyDate;
        private string _afterConnectScript;
        private string _bucketFolder;
        private string _bucketName;
        private int? _connectionTimeout;
        private string _databaseName;
        private string _dateFormat;
        private bool? _emptyAsNull;
        private EncryptionModeValue _encryptionMode;
        private int? _fileTransferUploadStreams;
        private int? _loadTimeout;
        private int? _maxFileSize;
        private string _password;
        private int? _port;
        private bool? _removeQuotes;
        private string _replaceChars;
        private string _replaceInvalidChars;
        private string _serverName;
        private string _serverSideEncryptionKmsKeyId;
        private string _serviceAccessRoleArn;
        private string _timeFormat;
        private bool? _trimBlanks;
        private bool? _truncateColumns;
        private string _username;
        private int? _writeBufferSize;

        /// <summary>
        /// Gets and sets the property AcceptAnyDate. 
        /// <para>
        /// Allows any date format, including invalid formats such as 00/00/00 00:00:00, to be
        /// loaded without generating an error. You can choose TRUE or FALSE (default).
        /// </para>
        ///  
        /// <para>
        /// This parameter applies only to TIMESTAMP and DATE columns. Always use ACCEPTANYDATE
        /// with the DATEFORMAT parameter. If the date format for the data does not match the
        /// DATEFORMAT specification, Amazon Redshift inserts a NULL value into that field. 
        /// </para>
        /// </summary>
        public bool AcceptAnyDate
        {
            get { return this._acceptAnyDate.GetValueOrDefault(); }
            set { this._acceptAnyDate = value; }
        }

        // Check to see if AcceptAnyDate property is set
        internal bool IsSetAcceptAnyDate()
        {
            return this._acceptAnyDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AfterConnectScript. 
        /// <para>
        /// Code to run after connecting. This should be the code, not a filename.
        /// </para>
        /// </summary>
        public string AfterConnectScript
        {
            get { return this._afterConnectScript; }
            set { this._afterConnectScript = value; }
        }

        // Check to see if AfterConnectScript property is set
        internal bool IsSetAfterConnectScript()
        {
            return this._afterConnectScript != null;
        }

        /// <summary>
        /// Gets and sets the property BucketFolder. 
        /// <para>
        /// The location where the CSV files are stored before being uploaded to the S3 bucket.
        /// 
        /// </para>
        /// </summary>
        public string BucketFolder
        {
            get { return this._bucketFolder; }
            set { this._bucketFolder = value; }
        }

        // Check to see if BucketFolder property is set
        internal bool IsSetBucketFolder()
        {
            return this._bucketFolder != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket you want to use
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionTimeout. 
        /// <para>
        /// Sets the amount of time to wait (in milliseconds) before timing out, beginning from
        /// when you initially establish a connection.
        /// </para>
        /// </summary>
        public int ConnectionTimeout
        {
            get { return this._connectionTimeout.GetValueOrDefault(); }
            set { this._connectionTimeout = value; }
        }

        // Check to see if ConnectionTimeout property is set
        internal bool IsSetConnectionTimeout()
        {
            return this._connectionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Amazon Redshift data warehouse (service) you are working with.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DateFormat. 
        /// <para>
        /// The date format you are using. Valid values are <code>auto</code> (case-sensitive),
        /// your date format string enclosed in quotes, or NULL. If this is left unset (NULL),
        /// it defaults to a format of 'YYYY-MM-DD'. Using <code>auto</code> recognizes most strings,
        /// even some that are not supported when you use a date format string. 
        /// </para>
        ///  
        /// <para>
        /// If your date and time values use formats different from each other, set this to <code>auto</code>.
        /// 
        /// </para>
        /// </summary>
        public string DateFormat
        {
            get { return this._dateFormat; }
            set { this._dateFormat = value; }
        }

        // Check to see if DateFormat property is set
        internal bool IsSetDateFormat()
        {
            return this._dateFormat != null;
        }

        /// <summary>
        /// Gets and sets the property EmptyAsNull. 
        /// <para>
        /// Specifies whether AWS DMS should migrate empty CHAR and VARCHAR fields as NULL. A
        /// value of TRUE sets empty CHAR and VARCHAR fields to null. The default is FALSE.
        /// </para>
        /// </summary>
        public bool EmptyAsNull
        {
            get { return this._emptyAsNull.GetValueOrDefault(); }
            set { this._emptyAsNull = value; }
        }

        // Check to see if EmptyAsNull property is set
        internal bool IsSetEmptyAsNull()
        {
            return this._emptyAsNull.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The type of server side encryption you want to use for your data. This is part of
        /// the endpoint settings or the extra connections attributes for Amazon S3. You can choose
        /// either SSE_S3 (default) or SSE_KMS. To use SSE_S3, create an IAM role with a policy
        /// that allows <code>"arn:aws:s3:::*"</code> to use the following actions: <code>"s3:PutObject",
        /// "s3:ListBucket"</code>.
        /// </para>
        /// </summary>
        public EncryptionModeValue EncryptionMode
        {
            get { return this._encryptionMode; }
            set { this._encryptionMode = value; }
        }

        // Check to see if EncryptionMode property is set
        internal bool IsSetEncryptionMode()
        {
            return this._encryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property FileTransferUploadStreams. 
        /// <para>
        /// Specifies the number of threads used to upload a single file. This accepts a value
        /// between 1 and 64. It defaults to 10.
        /// </para>
        /// </summary>
        public int FileTransferUploadStreams
        {
            get { return this._fileTransferUploadStreams.GetValueOrDefault(); }
            set { this._fileTransferUploadStreams = value; }
        }

        // Check to see if FileTransferUploadStreams property is set
        internal bool IsSetFileTransferUploadStreams()
        {
            return this._fileTransferUploadStreams.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadTimeout. 
        /// <para>
        /// Sets the amount of time to wait (in milliseconds) before timing out, beginning from
        /// when you begin loading.
        /// </para>
        /// </summary>
        public int LoadTimeout
        {
            get { return this._loadTimeout.GetValueOrDefault(); }
            set { this._loadTimeout = value; }
        }

        // Check to see if LoadTimeout property is set
        internal bool IsSetLoadTimeout()
        {
            return this._loadTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// Specifies the maximum size (in KB) of any CSV file used to transfer data to Amazon
        /// Redshift. This accepts a value between 1 and 1048576. It defaults to 32768 KB (32
        /// MB).
        /// </para>
        /// </summary>
        public int MaxFileSize
        {
            get { return this._maxFileSize.GetValueOrDefault(); }
            set { this._maxFileSize = value; }
        }

        // Check to see if MaxFileSize property is set
        internal bool IsSetMaxFileSize()
        {
            return this._maxFileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the user named in the username property.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for Amazon Redshift. The default value is 5439.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveQuotes. 
        /// <para>
        /// Removes surrounding quotation marks from strings in the incoming data. All characters
        /// within the quotation marks, including delimiters, are retained. Choose TRUE to remove
        /// quotation marks. The default is FALSE.
        /// </para>
        /// </summary>
        public bool RemoveQuotes
        {
            get { return this._removeQuotes.GetValueOrDefault(); }
            set { this._removeQuotes = value; }
        }

        // Check to see if RemoveQuotes property is set
        internal bool IsSetRemoveQuotes()
        {
            return this._removeQuotes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplaceChars. 
        /// <para>
        /// Replaces invalid characters specified in <code>ReplaceInvalidChars</code>, substituting
        /// the specified value instead. The default is "?".
        /// </para>
        /// </summary>
        public string ReplaceChars
        {
            get { return this._replaceChars; }
            set { this._replaceChars = value; }
        }

        // Check to see if ReplaceChars property is set
        internal bool IsSetReplaceChars()
        {
            return this._replaceChars != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceInvalidChars. 
        /// <para>
        /// A list of chars you want to replace. Use with <code>ReplaceChars</code>.
        /// </para>
        /// </summary>
        public string ReplaceInvalidChars
        {
            get { return this._replaceInvalidChars; }
            set { this._replaceInvalidChars = value; }
        }

        // Check to see if ReplaceInvalidChars property is set
        internal bool IsSetReplaceInvalidChars()
        {
            return this._replaceInvalidChars != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the Amazon Redshift cluster you are using.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKmsKeyId. 
        /// <para>
        /// If you are using SSE_KMS for the <code>EncryptionMode</code>, provide the KMS Key
        /// ID. The key you use needs an attached policy that enables IAM user permissions and
        /// allows use of the key.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionKmsKeyId
        {
            get { return this._serverSideEncryptionKmsKeyId; }
            set { this._serverSideEncryptionKmsKeyId = value; }
        }

        // Check to see if ServerSideEncryptionKmsKeyId property is set
        internal bool IsSetServerSideEncryptionKmsKeyId()
        {
            return this._serverSideEncryptionKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The ARN of the role that has access to the Redshift service.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimeFormat. 
        /// <para>
        /// The time format you want to use. Valid values are <code>auto</code> (case-sensitive),
        /// 'timeformat_string', 'epochsecs', or 'epochmillisecs'. It defaults to 10. Using <code>auto</code>
        /// recognizes most strings, even some that are not supported when you use a time format
        /// string. 
        /// </para>
        ///  
        /// <para>
        /// If your date and time values use formats different from each other, set this to <code>auto</code>.
        /// 
        /// </para>
        /// </summary>
        public string TimeFormat
        {
            get { return this._timeFormat; }
            set { this._timeFormat = value; }
        }

        // Check to see if TimeFormat property is set
        internal bool IsSetTimeFormat()
        {
            return this._timeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TrimBlanks. 
        /// <para>
        /// Removes the trailing white space characters from a VARCHAR string. This parameter
        /// applies only to columns with a VARCHAR data type. Choose TRUE to remove unneeded white
        /// space. The default is FALSE.
        /// </para>
        /// </summary>
        public bool TrimBlanks
        {
            get { return this._trimBlanks.GetValueOrDefault(); }
            set { this._trimBlanks = value; }
        }

        // Check to see if TrimBlanks property is set
        internal bool IsSetTrimBlanks()
        {
            return this._trimBlanks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TruncateColumns. 
        /// <para>
        /// Truncates data in columns to the appropriate number of characters, so that it fits
        /// in the column. Applies only to columns with a VARCHAR or CHAR data type, and rows
        /// with a size of 4 MB or less. Choose TRUE to truncate data. The default is FALSE.
        /// </para>
        /// </summary>
        public bool TruncateColumns
        {
            get { return this._truncateColumns.GetValueOrDefault(); }
            set { this._truncateColumns = value; }
        }

        // Check to see if TruncateColumns property is set
        internal bool IsSetTruncateColumns()
        {
            return this._truncateColumns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// An Amazon Redshift user name for a registered user.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property WriteBufferSize. 
        /// <para>
        /// The size of the write buffer to use in rows. Valid values range from 1 to 2048. Defaults
        /// to 1024. Use this setting to tune performance. 
        /// </para>
        /// </summary>
        public int WriteBufferSize
        {
            get { return this._writeBufferSize.GetValueOrDefault(); }
            set { this._writeBufferSize = value; }
        }

        // Check to see if WriteBufferSize property is set
        internal bool IsSetWriteBufferSize()
        {
            return this._writeBufferSize.HasValue; 
        }

    }
}