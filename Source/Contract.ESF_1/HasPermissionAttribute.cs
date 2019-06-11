using System;

namespace Contract.ESF_1
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class HasPermissionAttribute : Attribute
    {
        public HasPermissionAttribute(Enum permission)
        {
            Permission = permission.ToString();
        }

        public string Permission { get; }
    }
}
