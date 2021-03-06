// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Database level validation results
    /// </summary>
    public partial class MigrationValidationDatabaseLevelResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MigrationValidationDatabaseLevelResult class.
        /// </summary>
        public MigrationValidationDatabaseLevelResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MigrationValidationDatabaseLevelResult class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="migrationId">Migration Identifier</param>
        /// <param name="sourceDatabaseName">Name of the source
        /// database</param>
        /// <param name="targetDatabaseName">Name of the target
        /// database</param>
        /// <param name="startedOn">Validation start time</param>
        /// <param name="endedOn">Validation end time</param>
        /// <param name="dataIntegrityValidationResult">Provides data integrity
        /// validation result between the source and target tables that are
        /// migrated.</param>
        /// <param name="schemaValidationResult">Provides schema comparison
        /// result between source and target database</param>
        /// <param name="queryAnalysisValidationResult">Results of some of the
        /// query execution result between source and target database</param>
        /// <param name="status">Current status of validation at the database
        /// level. Possible values include: 'Default', 'NotStarted',
        /// 'Initialized', 'InProgress', 'Completed', 'CompletedWithIssues',
        /// 'Stopped', 'Failed'</param>
        public MigrationValidationDatabaseLevelResult(string id = default(string), string migrationId = default(string), string sourceDatabaseName = default(string), string targetDatabaseName = default(string), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? endedOn = default(System.DateTimeOffset?), DataIntegrityValidationResult dataIntegrityValidationResult = default(DataIntegrityValidationResult), SchemaComparisonValidationResult schemaValidationResult = default(SchemaComparisonValidationResult), QueryAnalysisValidationResult queryAnalysisValidationResult = default(QueryAnalysisValidationResult), string status = default(string))
        {
            Id = id;
            MigrationId = migrationId;
            SourceDatabaseName = sourceDatabaseName;
            TargetDatabaseName = targetDatabaseName;
            StartedOn = startedOn;
            EndedOn = endedOn;
            DataIntegrityValidationResult = dataIntegrityValidationResult;
            SchemaValidationResult = schemaValidationResult;
            QueryAnalysisValidationResult = queryAnalysisValidationResult;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets migration Identifier
        /// </summary>
        [JsonProperty(PropertyName = "migrationId")]
        public string MigrationId { get; private set; }

        /// <summary>
        /// Gets name of the source database
        /// </summary>
        [JsonProperty(PropertyName = "sourceDatabaseName")]
        public string SourceDatabaseName { get; private set; }

        /// <summary>
        /// Gets name of the target database
        /// </summary>
        [JsonProperty(PropertyName = "targetDatabaseName")]
        public string TargetDatabaseName { get; private set; }

        /// <summary>
        /// Gets validation start time
        /// </summary>
        [JsonProperty(PropertyName = "startedOn")]
        public System.DateTimeOffset? StartedOn { get; private set; }

        /// <summary>
        /// Gets validation end time
        /// </summary>
        [JsonProperty(PropertyName = "endedOn")]
        public System.DateTimeOffset? EndedOn { get; private set; }

        /// <summary>
        /// Gets provides data integrity validation result between the source
        /// and target tables that are migrated.
        /// </summary>
        [JsonProperty(PropertyName = "dataIntegrityValidationResult")]
        public DataIntegrityValidationResult DataIntegrityValidationResult { get; private set; }

        /// <summary>
        /// Gets provides schema comparison result between source and target
        /// database
        /// </summary>
        [JsonProperty(PropertyName = "schemaValidationResult")]
        public SchemaComparisonValidationResult SchemaValidationResult { get; private set; }

        /// <summary>
        /// Gets results of some of the query execution result between source
        /// and target database
        /// </summary>
        [JsonProperty(PropertyName = "queryAnalysisValidationResult")]
        public QueryAnalysisValidationResult QueryAnalysisValidationResult { get; private set; }

        /// <summary>
        /// Gets current status of validation at the database level. Possible
        /// values include: 'Default', 'NotStarted', 'Initialized',
        /// 'InProgress', 'Completed', 'CompletedWithIssues', 'Stopped',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

    }
}
