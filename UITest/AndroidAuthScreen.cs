using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace UITest
{
    public class AndroidAuthScreen: IAuthScreen
    {
        public Func<AppQuery, AppQuery> testRes { get; } = c => c.Id("");

    }
}
