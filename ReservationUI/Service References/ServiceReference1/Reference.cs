﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservationUI.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllBusiness", ReplyAction="http://tempuri.org/IService1/GetAllBusinessResponse")]
        ReservationModel.Business[] GetAllBusiness(int typeId, int directionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllBusiness", ReplyAction="http://tempuri.org/IService1/GetAllBusinessResponse")]
        System.Threading.Tasks.Task<ReservationModel.Business[]> GetAllBusinessAsync(int typeId, int directionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccount", ReplyAction="http://tempuri.org/IService1/GetAccountResponse")]
        ReservationModel.Account GetAccount(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccount", ReplyAction="http://tempuri.org/IService1/GetAccountResponse")]
        System.Threading.Tasks.Task<ReservationModel.Account> GetAccountAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReservation", ReplyAction="http://tempuri.org/IService1/GetReservationResponse")]
        ReservationModel.Reservation GetReservation(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReservation", ReplyAction="http://tempuri.org/IService1/GetReservationResponse")]
        System.Threading.Tasks.Task<ReservationModel.Reservation> GetReservationAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMessage", ReplyAction="http://tempuri.org/IService1/GetMessageResponse")]
        ReservationModel.Message GetMessage(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMessage", ReplyAction="http://tempuri.org/IService1/GetMessageResponse")]
        System.Threading.Tasks.Task<ReservationModel.Message> GetMessageAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteMessage", ReplyAction="http://tempuri.org/IService1/DeleteMessageResponse")]
        bool DeleteMessage(ReservationModel.Message message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteMessage", ReplyAction="http://tempuri.org/IService1/DeleteMessageResponse")]
        System.Threading.Tasks.Task<bool> DeleteMessageAsync(ReservationModel.Message message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClient", ReplyAction="http://tempuri.org/IService1/GetClientResponse")]
        ReservationModel.Client GetClient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClient", ReplyAction="http://tempuri.org/IService1/GetClientResponse")]
        System.Threading.Tasks.Task<ReservationModel.Client> GetClientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStyle", ReplyAction="http://tempuri.org/IService1/GetStyleResponse")]
        ReservationModel.Style GetStyle(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStyle", ReplyAction="http://tempuri.org/IService1/GetStyleResponse")]
        System.Threading.Tasks.Task<ReservationModel.Style> GetStyleAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDirection", ReplyAction="http://tempuri.org/IService1/GetDirectionResponse")]
        ReservationModel.Direction GetDirection(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDirection", ReplyAction="http://tempuri.org/IService1/GetDirectionResponse")]
        System.Threading.Tasks.Task<ReservationModel.Direction> GetDirectionAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusiness", ReplyAction="http://tempuri.org/IService1/GetBusinessResponse")]
        ReservationModel.Business GetBusiness(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBusiness", ReplyAction="http://tempuri.org/IService1/GetBusinessResponse")]
        System.Threading.Tasks.Task<ReservationModel.Business> GetBusinessAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAccount", ReplyAction="http://tempuri.org/IService1/CreateAccountResponse")]
        int CreateAccount(ReservationModel.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateAccount", ReplyAction="http://tempuri.org/IService1/CreateAccountResponse")]
        System.Threading.Tasks.Task<int> CreateAccountAsync(ReservationModel.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateClientAccount", ReplyAction="http://tempuri.org/IService1/CreateClientAccountResponse")]
        bool CreateClientAccount(ReservationModel.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateClientAccount", ReplyAction="http://tempuri.org/IService1/CreateClientAccountResponse")]
        System.Threading.Tasks.Task<bool> CreateClientAccountAsync(ReservationModel.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateBusinessAccount", ReplyAction="http://tempuri.org/IService1/CreateBusinessAccountResponse")]
        bool CreateBusinessAccount(ReservationModel.Business business);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateBusinessAccount", ReplyAction="http://tempuri.org/IService1/CreateBusinessAccountResponse")]
        System.Threading.Tasks.Task<bool> CreateBusinessAccountAsync(ReservationModel.Business business);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateDirection", ReplyAction="http://tempuri.org/IService1/CreateDirectionResponse")]
        int CreateDirection(ReservationModel.Direction direction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateDirection", ReplyAction="http://tempuri.org/IService1/CreateDirectionResponse")]
        System.Threading.Tasks.Task<int> CreateDirectionAsync(ReservationModel.Direction direction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditAccount", ReplyAction="http://tempuri.org/IService1/EditAccountResponse")]
        bool EditAccount(ReservationModel.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditAccount", ReplyAction="http://tempuri.org/IService1/EditAccountResponse")]
        System.Threading.Tasks.Task<bool> EditAccountAsync(ReservationModel.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllBusinessReservations", ReplyAction="http://tempuri.org/IService1/GetAllBusinessReservationsResponse")]
        ReservationModel.Reservation[] GetAllBusinessReservations(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllBusinessReservations", ReplyAction="http://tempuri.org/IService1/GetAllBusinessReservationsResponse")]
        System.Threading.Tasks.Task<ReservationModel.Reservation[]> GetAllBusinessReservationsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllClientReservations", ReplyAction="http://tempuri.org/IService1/GetAllClientReservationsResponse")]
        ReservationModel.Reservation[] GetAllClientReservations(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllClientReservations", ReplyAction="http://tempuri.org/IService1/GetAllClientReservationsResponse")]
        System.Threading.Tasks.Task<ReservationModel.Reservation[]> GetAllClientReservationsAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        ReservationModel.Account Login(string password, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<ReservationModel.Account> LoginAsync(string password, string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditClientAccount", ReplyAction="http://tempuri.org/IService1/EditClientAccountResponse")]
        bool EditClientAccount(ReservationModel.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditClientAccount", ReplyAction="http://tempuri.org/IService1/EditClientAccountResponse")]
        System.Threading.Tasks.Task<bool> EditClientAccountAsync(ReservationModel.Client client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditBusiness", ReplyAction="http://tempuri.org/IService1/EditBusinessResponse")]
        bool EditBusiness(ReservationModel.Business business);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditBusiness", ReplyAction="http://tempuri.org/IService1/EditBusinessResponse")]
        System.Threading.Tasks.Task<bool> EditBusinessAsync(ReservationModel.Business business);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateReservation", ReplyAction="http://tempuri.org/IService1/CreateReservationResponse")]
        bool CreateReservation(ReservationModel.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateReservation", ReplyAction="http://tempuri.org/IService1/CreateReservationResponse")]
        System.Threading.Tasks.Task<bool> CreateReservationAsync(ReservationModel.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditReservation", ReplyAction="http://tempuri.org/IService1/EditReservationResponse")]
        bool EditReservation(ReservationModel.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditReservation", ReplyAction="http://tempuri.org/IService1/EditReservationResponse")]
        System.Threading.Tasks.Task<bool> EditReservationAsync(ReservationModel.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteReservation", ReplyAction="http://tempuri.org/IService1/DeleteReservationResponse")]
        bool DeleteReservation(ReservationModel.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteReservation", ReplyAction="http://tempuri.org/IService1/DeleteReservationResponse")]
        System.Threading.Tasks.Task<bool> DeleteReservationAsync(ReservationModel.Reservation reservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchBusiness", ReplyAction="http://tempuri.org/IService1/SearchBusinessResponse")]
        ReservationModel.Business SearchBusiness(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchBusiness", ReplyAction="http://tempuri.org/IService1/SearchBusinessResponse")]
        System.Threading.Tasks.Task<ReservationModel.Business> SearchBusinessAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStyles", ReplyAction="http://tempuri.org/IService1/GetAllStylesResponse")]
        ReservationModel.Style[] GetAllStyles();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStyles", ReplyAction="http://tempuri.org/IService1/GetAllStylesResponse")]
        System.Threading.Tasks.Task<ReservationModel.Style[]> GetAllStylesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateMessage", ReplyAction="http://tempuri.org/IService1/CreateMessageResponse")]
        bool CreateMessage(ReservationModel.Message message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateMessage", ReplyAction="http://tempuri.org/IService1/CreateMessageResponse")]
        System.Threading.Tasks.Task<bool> CreateMessageAsync(ReservationModel.Message message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EndReservation", ReplyAction="http://tempuri.org/IService1/EndReservationResponse")]
        bool EndReservation(int reservationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EndReservation", ReplyAction="http://tempuri.org/IService1/EndReservationResponse")]
        System.Threading.Tasks.Task<bool> EndReservationAsync(int reservationId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ReservationUI.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ReservationUI.ServiceReference1.IService1>, ReservationUI.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ReservationModel.Business[] GetAllBusiness(int typeId, int directionId) {
            return base.Channel.GetAllBusiness(typeId, directionId);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Business[]> GetAllBusinessAsync(int typeId, int directionId) {
            return base.Channel.GetAllBusinessAsync(typeId, directionId);
        }
        
        public ReservationModel.Account GetAccount(int id) {
            return base.Channel.GetAccount(id);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Account> GetAccountAsync(int id) {
            return base.Channel.GetAccountAsync(id);
        }
        
        public ReservationModel.Reservation GetReservation(int id) {
            return base.Channel.GetReservation(id);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Reservation> GetReservationAsync(int id) {
            return base.Channel.GetReservationAsync(id);
        }
        
        public ReservationModel.Message GetMessage(int id) {
            return base.Channel.GetMessage(id);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Message> GetMessageAsync(int id) {
            return base.Channel.GetMessageAsync(id);
        }
        
        public bool DeleteMessage(ReservationModel.Message message) {
            return base.Channel.DeleteMessage(message);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteMessageAsync(ReservationModel.Message message) {
            return base.Channel.DeleteMessageAsync(message);
        }
        
        public ReservationModel.Client GetClient(int id) {
            return base.Channel.GetClient(id);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Client> GetClientAsync(int id) {
            return base.Channel.GetClientAsync(id);
        }
        
        public ReservationModel.Style GetStyle(int id) {
            return base.Channel.GetStyle(id);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Style> GetStyleAsync(int id) {
            return base.Channel.GetStyleAsync(id);
        }
        
        public ReservationModel.Direction GetDirection(int id) {
            return base.Channel.GetDirection(id);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Direction> GetDirectionAsync(int id) {
            return base.Channel.GetDirectionAsync(id);
        }
        
        public ReservationModel.Business GetBusiness(int id) {
            return base.Channel.GetBusiness(id);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Business> GetBusinessAsync(int id) {
            return base.Channel.GetBusinessAsync(id);
        }
        
        public int CreateAccount(ReservationModel.Account account) {
            return base.Channel.CreateAccount(account);
        }
        
        public System.Threading.Tasks.Task<int> CreateAccountAsync(ReservationModel.Account account) {
            return base.Channel.CreateAccountAsync(account);
        }
        
        public bool CreateClientAccount(ReservationModel.Client client) {
            return base.Channel.CreateClientAccount(client);
        }
        
        public System.Threading.Tasks.Task<bool> CreateClientAccountAsync(ReservationModel.Client client) {
            return base.Channel.CreateClientAccountAsync(client);
        }
        
        public bool CreateBusinessAccount(ReservationModel.Business business) {
            return base.Channel.CreateBusinessAccount(business);
        }
        
        public System.Threading.Tasks.Task<bool> CreateBusinessAccountAsync(ReservationModel.Business business) {
            return base.Channel.CreateBusinessAccountAsync(business);
        }
        
        public int CreateDirection(ReservationModel.Direction direction) {
            return base.Channel.CreateDirection(direction);
        }
        
        public System.Threading.Tasks.Task<int> CreateDirectionAsync(ReservationModel.Direction direction) {
            return base.Channel.CreateDirectionAsync(direction);
        }
        
        public bool EditAccount(ReservationModel.Account account) {
            return base.Channel.EditAccount(account);
        }
        
        public System.Threading.Tasks.Task<bool> EditAccountAsync(ReservationModel.Account account) {
            return base.Channel.EditAccountAsync(account);
        }
        
        public ReservationModel.Reservation[] GetAllBusinessReservations(int id) {
            return base.Channel.GetAllBusinessReservations(id);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Reservation[]> GetAllBusinessReservationsAsync(int id) {
            return base.Channel.GetAllBusinessReservationsAsync(id);
        }
        
        public ReservationModel.Reservation[] GetAllClientReservations(int id) {
            return base.Channel.GetAllClientReservations(id);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Reservation[]> GetAllClientReservationsAsync(int id) {
            return base.Channel.GetAllClientReservationsAsync(id);
        }
        
        public ReservationModel.Account Login(string password, string userName) {
            return base.Channel.Login(password, userName);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Account> LoginAsync(string password, string userName) {
            return base.Channel.LoginAsync(password, userName);
        }
        
        public bool EditClientAccount(ReservationModel.Client client) {
            return base.Channel.EditClientAccount(client);
        }
        
        public System.Threading.Tasks.Task<bool> EditClientAccountAsync(ReservationModel.Client client) {
            return base.Channel.EditClientAccountAsync(client);
        }
        
        public bool EditBusiness(ReservationModel.Business business) {
            return base.Channel.EditBusiness(business);
        }
        
        public System.Threading.Tasks.Task<bool> EditBusinessAsync(ReservationModel.Business business) {
            return base.Channel.EditBusinessAsync(business);
        }
        
        public bool CreateReservation(ReservationModel.Reservation reservation) {
            return base.Channel.CreateReservation(reservation);
        }
        
        public System.Threading.Tasks.Task<bool> CreateReservationAsync(ReservationModel.Reservation reservation) {
            return base.Channel.CreateReservationAsync(reservation);
        }
        
        public bool EditReservation(ReservationModel.Reservation reservation) {
            return base.Channel.EditReservation(reservation);
        }
        
        public System.Threading.Tasks.Task<bool> EditReservationAsync(ReservationModel.Reservation reservation) {
            return base.Channel.EditReservationAsync(reservation);
        }
        
        public bool DeleteReservation(ReservationModel.Reservation reservation) {
            return base.Channel.DeleteReservation(reservation);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteReservationAsync(ReservationModel.Reservation reservation) {
            return base.Channel.DeleteReservationAsync(reservation);
        }
        
        public ReservationModel.Business SearchBusiness(string name) {
            return base.Channel.SearchBusiness(name);
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Business> SearchBusinessAsync(string name) {
            return base.Channel.SearchBusinessAsync(name);
        }
        
        public ReservationModel.Style[] GetAllStyles() {
            return base.Channel.GetAllStyles();
        }
        
        public System.Threading.Tasks.Task<ReservationModel.Style[]> GetAllStylesAsync() {
            return base.Channel.GetAllStylesAsync();
        }
        
        public bool CreateMessage(ReservationModel.Message message) {
            return base.Channel.CreateMessage(message);
        }
        
        public System.Threading.Tasks.Task<bool> CreateMessageAsync(ReservationModel.Message message) {
            return base.Channel.CreateMessageAsync(message);
        }
        
        public bool EndReservation(int reservationId) {
            return base.Channel.EndReservation(reservationId);
        }
        
        public System.Threading.Tasks.Task<bool> EndReservationAsync(int reservationId) {
            return base.Channel.EndReservationAsync(reservationId);
        }
    }
}
