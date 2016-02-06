using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ploeh.AutoFixture;

namespace Stub.hcs_nsi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "hcs_nsi" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select hcs-nsi.svc or hcs-nsi.svc.cs at the Solution Explorer and start debugging.
    public class Nsi : INsi
    {
        Fixture fixture = new Fixture();
        public exportNsiListResponse exportNsiList(exportNsiListRequest1 request)
        {
            return fixture.Create<exportNsiListResponse>();
        }
    }
}
