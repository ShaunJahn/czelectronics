using czelectronics.Data.Models.MainForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Repository.Form
{
    public interface IForm : IDisposable
    {
        bool Save(FormUserInput formUserInput);
        List<FormUserInput> GetForms();
        FormUserInput GetFormById(int formId);
        bool UpdateFormStatudById(int formId, int statusId);
        int GetNextFormId();
    }
}
