using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Kernel;
using System.Xml;
using Moq;


namespace Stub.hcs_nsi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "hcs_nsi" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select hcs-nsi.svc or hcs-nsi.svc.cs at the Solution Explorer and start debugging.
    public class Nsi : INsi
    {

        //todo find out how to use fixture in this case. have a bunch of usolved problem's with abstract class realisation
        //Fixture fixture = new Fixture();
        private RequestHeader header;


        public Nsi()
        {
            //fixture.Customizations.Add(new TypeRelay(typeof(XmlNode),typeof(Helper)));
            //fixture.Customizations.Add(new TypeRelay(typeof(XmlResolver),typeof(Resolver)));
            //fixture.Customize(new AutoConfiguredMoqCustomization());
            header = new RequestHeader
            {
                MessageGUID = Guid.NewGuid().ToString(),
                Date = DateTime.Now,
                SenderID = "fake service"
            };

        }

        public exportNsiListResponse exportNsiList(exportNsiListRequest1 request)
        {
            return 
                new exportNsiListResponse()
                {
                    exportNsiListResult = new exportNsiListResult
                    {
                        Id = "1111111111111111111",
                    },
                    RequestHeader = header
                };
        }

        public Task<exportNsiListResponse> exportNsiListAsync(exportNsiListRequest1 request)
        {
            throw new NotImplementedException();
        }

        public exportNsiItemResponse exportNsiItem(exportNsiItemRequest1 request)
        {
            return new exportNsiItemResponse
            {
                RequestHeader = header,
                exportNsiItemResult = new exportNsiItemResult { Id="1"}
            };
        }

        public Task<exportNsiItemResponse> exportNsiItemAsync(exportNsiItemRequest1 request)
        {
            throw new NotImplementedException();
        }

        public importAdditionalServicesResponse importAdditionalServices(importAdditionalServicesRequest1 request)
        {
            return new importAdditionalServicesResponse
            {
                RequestHeader = header,
                ImportResult = new ImportResult {Id = "2"}
            };
        }

        public Task<importAdditionalServicesResponse> importAdditionalServicesAsync(importAdditionalServicesRequest1 request)
        {
            throw new NotImplementedException();
        }

        public importMunicipalServicesResponse importMunicipalServices(importMunicipalServicesRequest1 request)
        {
            return new importMunicipalServicesResponse
            {
                RequestHeader = header,
                ImportResult = new ImportResult {Id = "2"}
            };
        }

        public Task<importMunicipalServicesResponse> importMunicipalServicesAsync(importMunicipalServicesRequest1 request)
        {
            throw new NotImplementedException();
        }

        public importOrganizationWorksResponse importOrganizationWorks(importOrganizationWorksRequest1 request)
        {
            return new importOrganizationWorksResponse
            {
                RequestHeader = header,
                ImportResult = new ImportResult {Id = "3"}
            };
        }

        public Task<importOrganizationWorksResponse> importOrganizationWorksAsync(importOrganizationWorksRequest1 request)
        {
            throw new NotImplementedException();
        }
    }
}
