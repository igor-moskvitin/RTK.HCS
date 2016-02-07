using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Stub.hcs_organization_registry
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "hcs_organization_registry" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select hcs-organization-registry.svc or hcs-organization-registry.svc.cs at the Solution Explorer and start debugging.
    public class hcs_organization_registry : IRegOrgPortsType
    {
        private ResultHeader header;
        public hcs_organization_registry()
        {
            header = new ResultHeader
            {
                Date = DateTime.Now,
                MessageGUID = Guid.NewGuid().ToString()
            };
        }

        public exportOrgRegistryResponse exportOrgRegistry(exportOrgRegistryRequest1 request)
        {
            return new exportOrgRegistryResponse
            {
                ResultHeader = header
            };
        }

        public importDataProviderResponse importDataProvider(importDataProviderRequest1 request)
        {
            return new importDataProviderResponse
            {
                ResultHeader = header
            };
        }

   

        public exportDataProviderResponse exportDataProvider(exportDataProviderRequest1 request)
        {
            return new exportDataProviderResponse { ResultHeader = header };
        }

        public importSubsidiaryResponse importSubsidiary(importSubsidiaryRequest1 request)
        {
            return new importSubsidiaryResponse {ResultHeader = header};
        }
    }
}
