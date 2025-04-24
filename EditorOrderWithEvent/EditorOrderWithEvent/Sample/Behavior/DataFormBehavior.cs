using Syncfusion.Maui.DataForm;

namespace EditorOrderWithEvent
{
    public class DataFormBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.ItemsSourceProvider = new ItemSourceProvider();
            dataForm.RegisterEditor("Degree", DataFormEditorType.AutoComplete);
            dataForm.RegisterEditor("Branch", DataFormEditorType.ComboBox);
            dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
        }
        private void OnGenerateDataFormItem(object? sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.FieldName == "LastName")
                {
                    e.DataFormItem.RowOrder = 1;
                }
                else if (e.DataFormItem.FieldName == "Gender")
                {
                    e.DataFormItem.RowOrder = 2;
                }
                else if (e.DataFormItem.FieldName == "FirstName")
                {
                    e.DataFormItem.RowOrder = 0;
                }
                else if (e.DataFormItem.FieldName == "GraduationDate")
                {
                    e.DataFormItem.RowOrder = 2;
                }
                else if (e.DataFormItem.FieldName == "Degree")
                {
                    e.DataFormItem.RowOrder = 0;
                }
                else if (e.DataFormItem.FieldName == "Branch")
                {
                    e.DataFormItem.RowOrder = 1;
                }
            }
        }
        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
            if (dataForm != null)
            {
                dataForm.GenerateDataFormItem -= this.OnGenerateDataFormItem;
            }
        }
    }
}