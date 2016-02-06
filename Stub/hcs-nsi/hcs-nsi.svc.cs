﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace Stub.hcs_nsi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "hcs_nsi" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select hcs-nsi.svc or hcs-nsi.svc.cs at the Solution Explorer and start debugging.
    public class Nsi : INsi
    {
        Fixture fixture = new Fixture();

        public Nsi()
        {
            //fixture.Customizations.Add(new AutoMoqCustomization());
        }

        public exportNsiListResponse exportNsiList(exportNsiListRequest1 request)
        {
            return fixture.Create<exportNsiListResponse>();
        }

        public Task<exportNsiListResponse> exportNsiListAsync(exportNsiListRequest1 request)
        {
            throw new NotImplementedException();
        }

        public exportNsiItemResponse exportNsiItem(exportNsiItemRequest1 request)
        {
            throw new NotImplementedException();
        }

        public Task<exportNsiItemResponse> exportNsiItemAsync(exportNsiItemRequest1 request)
        {
            throw new NotImplementedException();
        }

        public importAdditionalServicesResponse importAdditionalServices(importAdditionalServicesRequest1 request)
        {
            throw new NotImplementedException();
        }

        public Task<importAdditionalServicesResponse> importAdditionalServicesAsync(importAdditionalServicesRequest1 request)
        {
            throw new NotImplementedException();
        }

        public importMunicipalServicesResponse importMunicipalServices(importMunicipalServicesRequest1 request)
        {
            throw new NotImplementedException();
        }

        public Task<importMunicipalServicesResponse> importMunicipalServicesAsync(importMunicipalServicesRequest1 request)
        {
            throw new NotImplementedException();
        }

        public importOrganizationWorksResponse importOrganizationWorks(importOrganizationWorksRequest1 request)
        {
            throw new NotImplementedException();
        }

        public Task<importOrganizationWorksResponse> importOrganizationWorksAsync(importOrganizationWorksRequest1 request)
        {
            throw new NotImplementedException();
        }
    }
}
