using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSorter
{
    public partial class CategoryNamePopup : Form
    {
        EventHandler applyAction;
        EventHandler cancelAction;

        public CategoryNamePopup(EventHandler _applyAction, EventHandler _cancelAction)
        {
            InitializeComponent();
            applyAction = _applyAction;
            cancelAction = _cancelAction;
            ApplyCategory.Click += applyAction;
            CancelCategory.Click += cancelAction;
            AcceptButton = ApplyCategory;
            CancelButton = CancelCategory;
        }

        public string GetName()
        {
            return CategoryName.Text;
        }
    }
}
