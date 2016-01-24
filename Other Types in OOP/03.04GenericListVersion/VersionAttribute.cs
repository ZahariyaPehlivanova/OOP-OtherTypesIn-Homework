using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04GenericListVersion
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = true)]

    public class VersionAttribute : Attribute
    {
        private int minorVersion;
        private int majorVersion;

        public VersionAttribute(int majorVersion, int minorVersion)
        {
            this.MajorVersion = majorVersion;
            this.MinorVersion = minorVersion;
        }
        public int MajorVersion
        {
            get
            { return this.majorVersion; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Major version value cannot be negative.");
                }
                this.majorVersion = value;
            }
        }

        public int MinorVersion
        {
            get
            { return this.minorVersion; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Minor version value cannot be negative.");
                }
                this.minorVersion = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Version {0}.{1}", this.MajorVersion, this.MinorVersion);
        }
    }

}
