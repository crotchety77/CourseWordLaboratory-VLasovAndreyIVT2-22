using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkLaboratory_VLasovAndreyIVT2_22 {
    internal class User {
        public int id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string FullName {
            get {
                return $"{Name} {Family}";
            }
        }
    }
}
