using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    public class Material
    {
        private string _name;
        private int _id;

        public Material(string name, int id)
        {
            _name = name;
            _id = id;
        }
        public Material()
        {
            _name = "NULL";
            _id = -1;
        }

        public Material(Material material)
        {
            _name = material._name;
            _id = material._id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public void Copy(Material temp)
        {
            _name = temp._name;
            _id = temp._id;
        }
    }
}
