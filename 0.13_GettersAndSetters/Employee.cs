using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GettersAndSetters {
    class Employee {

        //Fields
        private int _id;

        //Constructors


        //Properties
        public int EmployeeId {
            set {
                if (EmployeeId < 1)
                    throw new Exception("The Employee Id is not valid.");
                this._id = value;
            }
            get {
                return this._id;
            }
        }
         
        private string _name;

        public string Name {
            set {
                if(string.IsNullOrEmpty(value)) {
                    throw new Exception("It is not valid.");
                }
                this._name = value;
            }
            get {
                return this._name;
            }
        }

        //Methods

    }
}
