using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Stub.hcs_nsi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ihcs_nsi" in both code and config file together.
    [ServiceContract]
    public interface INsi
    {

        // CODEGEN: Контракт генерации сообщений с операцией exportNsiList не является ни RPC, ни упакованным документом.
        [OperationContract]//(Action = "urn:exportNsiList", ReplyAction = "*")]
        //[FaultContract(typeof(dom.gosuslugi.ru.schema.integration._8._51._02._23.Fault), Action = "urn:exportNsiList", Name = "Fault", Namespace = "http://dom.gosuslugi.ru/schema/integration/8.5.0.2/")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(CompletedWorkExportType))]
        [ServiceKnownType(typeof(CompletedWorksByPeriodExportType))]
        [ServiceKnownType(typeof(CompletedWorkType))]
        [ServiceKnownType(typeof(WorkingListItemType))]
        [ServiceKnownType(typeof(WorkingListBaseType))]
        [ServiceKnownType(typeof(MunicipalServiceType))]
        [ServiceKnownType(typeof(DocumentPortalType))]
        [ServiceKnownType(typeof(AcknowledgmentRequestInfoType))]
        [ServiceKnownType(typeof(NotificationOfOrderExecutionType))]
        [ServiceKnownType(typeof(SubsidiaryImportType))]
        [ServiceKnownType(typeof(SubsidiaryType))]
        [ServiceKnownType(typeof(AccompanyingDocumentType))]
        [ServiceKnownType(typeof(LicenseType))]
        [ServiceKnownType(typeof(ResourceType))]
        [ServiceKnownType(typeof(InfrastructureType))]
        [ServiceKnownType(typeof(LivingHouseUpdateOMSType))]
        [ServiceKnownType(typeof(LivingHouseOMSType))]
        [ServiceKnownType(typeof(EntranceUpdateOMSType))]
        [ServiceKnownType(typeof(ApartmentHouseUpdateOMSType))]
        [ServiceKnownType(typeof(ApartmentHouseOMSType))]
        [ServiceKnownType(typeof(LivingHouseUpdateRSOType))]
        [ServiceKnownType(typeof(LivingHouseRSOType))]
        [ServiceKnownType(typeof(EntranceUpdateRSOType))]
        [ServiceKnownType(typeof(EntranceRSOType))]
        [ServiceKnownType(typeof(ApartmentHouseUpdateRSOType))]
        [ServiceKnownType(typeof(GKNRSOType))]
        [ServiceKnownType(typeof(ApartmentHouseRSOType))]
        [ServiceKnownType(typeof(LivingHouseUpdateUOType))]
        [ServiceKnownType(typeof(LivingHouseUOType))]
        [ServiceKnownType(typeof(EntranceUpdateUOType))]
        [ServiceKnownType(typeof(EntranceUOType))]
        [ServiceKnownType(typeof(ApartmentHouseUpdateUOType))]
        [ServiceKnownType(typeof(ApartmentHouseUOType))]
        [ServiceKnownType(typeof(VoitingType))]
        [ServiceKnownType(typeof(ProtocolType))]
        [ServiceKnownType(typeof(AccountType))]
        [ServiceKnownType(typeof(LivingHouseExportType))]
        [ServiceKnownType(typeof(GKNType))]
        [ServiceKnownType(typeof(EntranceOMSType))]
        [ServiceKnownType(typeof(GKNExportType))]
        [ServiceKnownType(typeof(ApartmentHouseExportType))]
        [ServiceKnownType(typeof(CharterType))]
        [ServiceKnownType(typeof(GKNRelationshipStatusType))]
        [ServiceKnownType(typeof(TerminateType))]
        [ServiceKnownType(typeof(ContractServiceType))]
        [ServiceKnownType(typeof(ManageObjectType))]
        [ServiceKnownType(typeof(ContractType))]
        [ServiceKnownType(typeof(PartSizeType))]
        [ServiceKnownType(typeof(ElectricMeteringDeviceType))]
        [ServiceKnownType(typeof(OneRateMeteringDeviceType))]
        [ServiceKnownType(typeof(SubSection1ElementType))]
        [ServiceKnownType(typeof(ElectricMeteringValueKindType))]
        [ServiceKnownType(typeof(OneRateMeteringValueKindType))]
        [ServiceKnownType(typeof(ServiceInformationType))]
        [ServiceKnownType(typeof(PDServiceChargeType))]
        [ServiceKnownType(typeof(PaymentDocumentType))]
        [ServiceKnownType(typeof(BaseType))]
        exportNsiListResponse exportNsiList(exportNsiListRequest1 request);

    }
}
