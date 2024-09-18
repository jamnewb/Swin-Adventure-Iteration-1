using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventureIteration1
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();

            foreach (string ident in idents) 
            {
                _identifiers.Add(ident);
            }
        }

        public bool AreYou(string id)
        {
            foreach (string ident in _identifiers) 
            {
                if (ident.Equals(id.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

        public string FirstId
        {
            get
            {
                if (_identifiers.Count > 0)
                {
                    return _identifiers[0];
                }
                else
                {
                    return "";
                }
            }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
