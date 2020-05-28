// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.DataFactory
{
    /// <summary>
    /// Manages a SQL Server Table Dataset inside a Azure Data Factory.
    /// 
    /// ## Example Usage
    /// 
    /// 
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleResourceGroup = new Azure.Core.ResourceGroup("exampleResourceGroup", new Azure.Core.ResourceGroupArgs
    ///         {
    ///             Location = "northeurope",
    ///         });
    ///         var exampleFactory = new Azure.DataFactory.Factory("exampleFactory", new Azure.DataFactory.FactoryArgs
    ///         {
    ///             Location = exampleResourceGroup.Location,
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///         });
    ///         var exampleLinkedServiceSqlServer = new Azure.DataFactory.LinkedServiceSqlServer("exampleLinkedServiceSqlServer", new Azure.DataFactory.LinkedServiceSqlServerArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             DataFactoryName = exampleFactory.Name,
    ///             ConnectionString = "Integrated Security=False;Data Source=test;Initial Catalog=test;User ID=test;Password=test",
    ///         });
    ///         var exampleDatasetSqlServerTable = new Azure.DataFactory.DatasetSqlServerTable("exampleDatasetSqlServerTable", new Azure.DataFactory.DatasetSqlServerTableArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             DataFactoryName = exampleFactory.Name,
    ///             LinkedServiceName = exampleLinkedServiceSqlServer.Name,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class DatasetSqlServerTable : Pulumi.CustomResource
    {
        /// <summary>
        /// A map of additional properties to associate with the Data Factory Dataset SQL Server Table.
        /// </summary>
        [Output("additionalProperties")]
        public Output<ImmutableDictionary<string, string>?> AdditionalProperties { get; private set; } = null!;

        /// <summary>
        /// List of tags that can be used for describing the Data Factory Dataset SQL Server Table.
        /// </summary>
        [Output("annotations")]
        public Output<ImmutableArray<string>> Annotations { get; private set; } = null!;

        /// <summary>
        /// The Data Factory name in which to associate the Dataset with. Changing this forces a new resource.
        /// </summary>
        [Output("dataFactoryName")]
        public Output<string> DataFactoryName { get; private set; } = null!;

        /// <summary>
        /// The description for the Data Factory Dataset SQL Server Table.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.
        /// </summary>
        [Output("folder")]
        public Output<string?> Folder { get; private set; } = null!;

        /// <summary>
        /// The Data Factory Linked Service name in which to associate the Dataset with.
        /// </summary>
        [Output("linkedServiceName")]
        public Output<string> LinkedServiceName { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Data Factory Dataset SQL Server Table. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A map of parameters to associate with the Data Factory Dataset SQL Server Table.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, string>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Data Factory Dataset SQL Server Table. Changing this forces a new resource
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A `schema_column` block as defined below.
        /// </summary>
        [Output("schemaColumns")]
        public Output<ImmutableArray<Outputs.DatasetSqlServerTableSchemaColumn>> SchemaColumns { get; private set; } = null!;

        /// <summary>
        /// The table name of the Data Factory Dataset SQL Server Table.
        /// </summary>
        [Output("tableName")]
        public Output<string?> TableName { get; private set; } = null!;


        /// <summary>
        /// Create a DatasetSqlServerTable resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DatasetSqlServerTable(string name, DatasetSqlServerTableArgs args, CustomResourceOptions? options = null)
            : base("azure:datafactory/datasetSqlServerTable:DatasetSqlServerTable", name, args ?? new DatasetSqlServerTableArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DatasetSqlServerTable(string name, Input<string> id, DatasetSqlServerTableState? state = null, CustomResourceOptions? options = null)
            : base("azure:datafactory/datasetSqlServerTable:DatasetSqlServerTable", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DatasetSqlServerTable resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DatasetSqlServerTable Get(string name, Input<string> id, DatasetSqlServerTableState? state = null, CustomResourceOptions? options = null)
        {
            return new DatasetSqlServerTable(name, id, state, options);
        }
    }

    public sealed class DatasetSqlServerTableArgs : Pulumi.ResourceArgs
    {
        [Input("additionalProperties")]
        private InputMap<string>? _additionalProperties;

        /// <summary>
        /// A map of additional properties to associate with the Data Factory Dataset SQL Server Table.
        /// </summary>
        public InputMap<string> AdditionalProperties
        {
            get => _additionalProperties ?? (_additionalProperties = new InputMap<string>());
            set => _additionalProperties = value;
        }

        [Input("annotations")]
        private InputList<string>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Data Factory Dataset SQL Server Table.
        /// </summary>
        public InputList<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// The Data Factory name in which to associate the Dataset with. Changing this forces a new resource.
        /// </summary>
        [Input("dataFactoryName", required: true)]
        public Input<string> DataFactoryName { get; set; } = null!;

        /// <summary>
        /// The description for the Data Factory Dataset SQL Server Table.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.
        /// </summary>
        [Input("folder")]
        public Input<string>? Folder { get; set; }

        /// <summary>
        /// The Data Factory Linked Service name in which to associate the Dataset with.
        /// </summary>
        [Input("linkedServiceName", required: true)]
        public Input<string> LinkedServiceName { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Data Factory Dataset SQL Server Table. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of parameters to associate with the Data Factory Dataset SQL Server Table.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which to create the Data Factory Dataset SQL Server Table. Changing this forces a new resource
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("schemaColumns")]
        private InputList<Inputs.DatasetSqlServerTableSchemaColumnArgs>? _schemaColumns;

        /// <summary>
        /// A `schema_column` block as defined below.
        /// </summary>
        public InputList<Inputs.DatasetSqlServerTableSchemaColumnArgs> SchemaColumns
        {
            get => _schemaColumns ?? (_schemaColumns = new InputList<Inputs.DatasetSqlServerTableSchemaColumnArgs>());
            set => _schemaColumns = value;
        }

        /// <summary>
        /// The table name of the Data Factory Dataset SQL Server Table.
        /// </summary>
        [Input("tableName")]
        public Input<string>? TableName { get; set; }

        public DatasetSqlServerTableArgs()
        {
        }
    }

    public sealed class DatasetSqlServerTableState : Pulumi.ResourceArgs
    {
        [Input("additionalProperties")]
        private InputMap<string>? _additionalProperties;

        /// <summary>
        /// A map of additional properties to associate with the Data Factory Dataset SQL Server Table.
        /// </summary>
        public InputMap<string> AdditionalProperties
        {
            get => _additionalProperties ?? (_additionalProperties = new InputMap<string>());
            set => _additionalProperties = value;
        }

        [Input("annotations")]
        private InputList<string>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Data Factory Dataset SQL Server Table.
        /// </summary>
        public InputList<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// The Data Factory name in which to associate the Dataset with. Changing this forces a new resource.
        /// </summary>
        [Input("dataFactoryName")]
        public Input<string>? DataFactoryName { get; set; }

        /// <summary>
        /// The description for the Data Factory Dataset SQL Server Table.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The folder that this Dataset is in. If not specified, the Dataset will appear at the root level.
        /// </summary>
        [Input("folder")]
        public Input<string>? Folder { get; set; }

        /// <summary>
        /// The Data Factory Linked Service name in which to associate the Dataset with.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<string>? LinkedServiceName { get; set; }

        /// <summary>
        /// Specifies the name of the Data Factory Dataset SQL Server Table. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of parameters to associate with the Data Factory Dataset SQL Server Table.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which to create the Data Factory Dataset SQL Server Table. Changing this forces a new resource
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("schemaColumns")]
        private InputList<Inputs.DatasetSqlServerTableSchemaColumnGetArgs>? _schemaColumns;

        /// <summary>
        /// A `schema_column` block as defined below.
        /// </summary>
        public InputList<Inputs.DatasetSqlServerTableSchemaColumnGetArgs> SchemaColumns
        {
            get => _schemaColumns ?? (_schemaColumns = new InputList<Inputs.DatasetSqlServerTableSchemaColumnGetArgs>());
            set => _schemaColumns = value;
        }

        /// <summary>
        /// The table name of the Data Factory Dataset SQL Server Table.
        /// </summary>
        [Input("tableName")]
        public Input<string>? TableName { get; set; }

        public DatasetSqlServerTableState()
        {
        }
    }
}
