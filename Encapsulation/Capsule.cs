using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{

    // this is basic method to implement encapsulation in c# using class and private access modifier
    // encapsulation use access modifiers to restrict access betweet class, method, data members
    // 4 type of access modifiers in c# are public, private, protected, internal
    // public: accessible from anywhere
    // private: accessible only within the class
    // protected: accessible within the class and derived class
    // internal: accessible within the same assembly(project)
    class Capsule
    {
        private int id;
        private string? name;   // avoid null reference exception or warings, use nullable reference type
        private string? description;

        public void setvalue(int id, string? name, string? description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
        public (int, string?, string?) getvalue()
        {
            int getId = this.id;
            string? getName = this.name;
            string? getDescription = this.description;

            return (getId, getName, getDescription);
        }
        
    }
}
