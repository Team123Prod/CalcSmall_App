using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace UITest
{
    public interface IAuthScreen
    {
        Func<AppQuery, AppQuery> testRes { get; }
    }
}
