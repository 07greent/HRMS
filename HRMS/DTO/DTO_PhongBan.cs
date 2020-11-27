using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DTO
{
    public class DTO_PhongBan
    {
        private string _PhongBan_MaPB;
        private string _PhongBan_TenPB;

        /* Get/Set */
        public string PhongBan_MaPB
        {
            get
            {
                return _PhongBan_MaPB;
            }
            set
            {
                _PhongBan_MaPB = value;
            }
        }
        public string PhongBan_TenPB
        {
            get
            {
                return _PhongBan_TenPB;
            }
            set
            {
                _PhongBan_TenPB = value;
            }
        }
        /* Constructor */
        public DTO_PhongBan()
        {
        }
    }
}
