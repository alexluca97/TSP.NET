using PostComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProjectCarService;

namespace WCFCarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        void AddClient(Client client);

        [OperationContract]
        void AddAuto(Auto auto);

        [OperationContract]
        void AddComanda(Comanda comanda);

        [OperationContract]
        void AddDetaliuComanda(DetaliuComanda detaliuComanda);

        [OperationContract]
        void AddImage(Imagine imagine);

        [OperationContract]
        void AddMaterial(Material material);

        [OperationContract]
        void AddMecanic(Mecanic mecanic);

        [OperationContract]
        void AddOperatie(Operatie operatie);

        [OperationContract]
        void AddSasiu(Sasiu sasiu);

        //[OperationContract]
        //void AddAuto(int clientId, Sasiu sasiu, string nrTarga, string serieSasiu);

        //[OperationContract]
        //void AddComanda(int idClient, int autoId, int kmBord, DateTime dataProgramare, string descriere);

        [OperationContract]
        List<Auto> GetAllAuto();

        [OperationContract]
        List<Auto> GetAutoByClientId(int clientId);

        [OperationContract]
        List<Client> GetAllClients();

        [OperationContract]
        List<Comanda> GetAllComands();

        [OperationContract]
        List<Material> GetAllMaterials();

        [OperationContract]
        List<Mecanic> GetAllMecanics();

        [OperationContract]
        List<DetaliuComanda> GetAllDetailsCommands();

        [OperationContract]
        List<Imagine> GetAllImagies();

        [OperationContract]
        List<Operatie> GetOperations();

        [OperationContract]
        List<Sasiu> GetAllChassis();

        [OperationContract]
        Sasiu GetSasiuByCodeAndName(string code, string name);

        [OperationContract]
        Client GetClient(int id);

        [OperationContract]
        Sasiu GetSasiu(int id);

        [OperationContract]
        Auto GetAuto(int id);

        [OperationContract]
        Comanda GetComanda(int id);

        [OperationContract]
        DetaliuComanda GetDetaliuComanda(int id);

        [OperationContract]
        Imagine GetImagine(int id);

        [OperationContract]
        Material GetMaterial(int id);

        [OperationContract]
        Mecanic GetMecanic(int id);

        [OperationContract]
        Operatie GetOperatie(int id);

        [OperationContract]
        void DeleteClientAutoSasiu(int idClient);

        [OperationContract]
        void DeleteClient(int clientId);

        [OperationContract]
        void DeleteAuto(int autoId);

        [OperationContract]
        void DeleteComanda(int comandaId);

        [OperationContract]
        void DeleteMaterial(int materialId);

        [OperationContract]
        void DeleteMecanic(int mecanicId);

        [OperationContract]
        void DeleteOperatie(int operatieId);

        [OperationContract]
        void DeleteSasiu(int sasiuId);

        [OperationContract]
        void DeleteDetaliuComanda(int detaliuComandaId);

        [OperationContract]
        void DeleteImage(int imagineId);

        [OperationContract]
        void UpdateClient(Client client);

        [OperationContract]
        void UpdateAuto(Auto auto);

        [OperationContract]
        void UpdateComanda(Comanda comanda);

        [OperationContract]
        void UpdateDetaliuComanda(DetaliuComanda detaliuComanda);

        [OperationContract]
        void UpdateImaine(Imagine imagine);

        [OperationContract]
        void UpdateMaterial(Material material);

        [OperationContract]
        void UpdateMecanic(Mecanic mecanic);

        [OperationContract]
        void UpdateOperatie(Operatie operatie);

        [OperationContract]
        void UpdateSasiu(Sasiu sasiu);
    }
}
