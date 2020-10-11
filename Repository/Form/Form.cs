using czelectronics.Data;
using czelectronics.Data.Models.MainForm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Repository.Form
{
    public class Form : IForm
    {
        private readonly CzElectornicsDbContext _context;

        public Form(CzElectornicsDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public FormUserInput GetFormById(int formId)
        {
            return _context.Forms.Where(x => x.FormUserInputId == formId)
                                                .AsNoTracking()
                                                .Include(x => x.StoreCode)
                                                .Include(x => x.Customer)
                                                .Include(x => x.Status)
                                                .Include(x => x.ProductsNavigation)
                                                    .ThenInclude(x => x.ProductTypeNavigation)
                                                .FirstOrDefault();
        }

        public List<FormUserInput> GetForms()
        {
            return _context.Forms.AsNoTracking().Include(x => x.StoreCode)
                                                .Include(x => x.Customer)
                                                .Include(x => x.Status)
                                                .ToList();
        }

        public int GetNextFormId()
        {
            var num = _context.Forms.ToList().OrderByDescending(x => x.FormUserInputId).Select(x => x.FormUserInputId).First() + 1;
            return num;
        }

        public bool Save(FormUserInput formUserInput)
        {
            try
            {
                _context.Add(formUserInput);
                _context.SaveChanges();
                return true;
            }
            catch (Exception err)
            {
                return false;
            }

        }

        public bool UpdateFormStatudById(int formId, int statusId)
        {
            try
            {
                var form = _context.Forms.Where(x => x.FormUserInputId == formId).FirstOrDefault();
                form.StatusId = statusId;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
