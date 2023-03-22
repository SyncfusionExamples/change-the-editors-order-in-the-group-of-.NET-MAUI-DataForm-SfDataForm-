using Syncfusion.Maui.DataForm;

namespace EditorOrderWithAttribute
{
    public class DataFormBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            dataForm.ItemsSourceProvider = new ItemSourceProvider();
            dataForm.RegisterEditor("Degree", DataFormEditorType.AutoComplete);
            dataForm.RegisterEditor("Branch", DataFormEditorType.ComboBox);
        }
    }
}