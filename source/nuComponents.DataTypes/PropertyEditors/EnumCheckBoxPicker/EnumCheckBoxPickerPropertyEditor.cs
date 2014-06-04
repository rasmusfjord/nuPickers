﻿
namespace nuComponents.DataTypes.PropertyEditors.EnumCheckBoxPicker
{
    using ClientDependency.Core;
    using Umbraco.Core.PropertyEditors;
    using Umbraco.Web.PropertyEditors;
    using nuComponents.DataTypes.PropertyEditors;
    
    // EDITOR UI
    [PropertyEditor(PropertyEditorConstants.EnumCheckBoxPickerAlias, "nuComponents: Enum CheckBox Picker", EmbeddedResource.RootUrl + "CheckBoxPicker/CheckBoxPickerEditor.html", ValueType = "TEXT")]
    [PropertyEditorAsset(ClientDependencyType.Css, EmbeddedResource.RootUrl + "LayoutDirection/LayoutDirection.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "CheckBoxPicker/CheckBoxPickerEditorController.js")]

    // RESOURCES
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "SaveFormat/SaveFormatResource.js")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "DataSource/DataSourceResource.js")]

    // CONFIG
    [PropertyEditorAsset(ClientDependencyType.Css, EmbeddedResource.RootUrl + "PropertyEditor/PropertyEditorConfig.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "EnumDataSource/EnumDataSourceConfigController.js")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "CustomLabel/CustomLabelConfigController.js")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, EmbeddedResource.RootUrl + "RelationTypeMapping/RelationTypeMappingConfigController.js")]
    public class EnumCheckBoxPickerPropertyEditor : BasePropertyEditor
    {
        protected override PreValueEditor CreatePreValueEditor()
        {
            return new EnumCheckBoxPickerPreValueEditor();
        }
    }
}
