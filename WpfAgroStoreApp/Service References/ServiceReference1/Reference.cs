﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAgroStoreApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSuppliers", ReplyAction="http://tempuri.org/IService1/GetAllSuppliersResponse")]
        WcfService.vwSupplier[] GetAllSuppliers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSuppliers", ReplyAction="http://tempuri.org/IService1/GetAllSuppliersResponse")]
        System.Threading.Tasks.Task<WcfService.vwSupplier[]> GetAllSuppliersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddSupplier", ReplyAction="http://tempuri.org/IService1/AddSupplierResponse")]
        WcfService.vwSupplier AddSupplier(WcfService.vwSupplier supplier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddSupplier", ReplyAction="http://tempuri.org/IService1/AddSupplierResponse")]
        System.Threading.Tasks.Task<WcfService.vwSupplier> AddSupplierAsync(WcfService.vwSupplier supplier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSupplier", ReplyAction="http://tempuri.org/IService1/DeleteSupplierResponse")]
        void DeleteSupplier(int supplierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteSupplier", ReplyAction="http://tempuri.org/IService1/DeleteSupplierResponse")]
        System.Threading.Tasks.Task DeleteSupplierAsync(int supplierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsSupplierExist", ReplyAction="http://tempuri.org/IService1/IsSupplierExistResponse")]
        bool IsSupplierExist(int supplierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsSupplierExist", ReplyAction="http://tempuri.org/IService1/IsSupplierExistResponse")]
        System.Threading.Tasks.Task<bool> IsSupplierExistAsync(int supplierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCustomers", ReplyAction="http://tempuri.org/IService1/GetAllCustomersResponse")]
        WcfService.vwCustomer[] GetAllCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCustomers", ReplyAction="http://tempuri.org/IService1/GetAllCustomersResponse")]
        System.Threading.Tasks.Task<WcfService.vwCustomer[]> GetAllCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCustomer", ReplyAction="http://tempuri.org/IService1/AddCustomerResponse")]
        WcfService.vwCustomer AddCustomer(WcfService.vwCustomer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCustomer", ReplyAction="http://tempuri.org/IService1/AddCustomerResponse")]
        System.Threading.Tasks.Task<WcfService.vwCustomer> AddCustomerAsync(WcfService.vwCustomer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCustomer", ReplyAction="http://tempuri.org/IService1/DeleteCustomerResponse")]
        void DeleteCustomer(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCustomer", ReplyAction="http://tempuri.org/IService1/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsCustomerExist", ReplyAction="http://tempuri.org/IService1/IsCustomerExistResponse")]
        bool IsCustomerExist(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsCustomerExist", ReplyAction="http://tempuri.org/IService1/IsCustomerExistResponse")]
        System.Threading.Tasks.Task<bool> IsCustomerExistAsync(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCategories", ReplyAction="http://tempuri.org/IService1/GetAllCategoriesResponse")]
        WcfService.vwCategory[] GetAllCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCategories", ReplyAction="http://tempuri.org/IService1/GetAllCategoriesResponse")]
        System.Threading.Tasks.Task<WcfService.vwCategory[]> GetAllCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCategory", ReplyAction="http://tempuri.org/IService1/AddCategoryResponse")]
        WcfService.vwCategory AddCategory(WcfService.vwCategory category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCategory", ReplyAction="http://tempuri.org/IService1/AddCategoryResponse")]
        System.Threading.Tasks.Task<WcfService.vwCategory> AddCategoryAsync(WcfService.vwCategory category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCategory", ReplyAction="http://tempuri.org/IService1/DeleteCategoryResponse")]
        void DeleteCategory(int categoryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCategory", ReplyAction="http://tempuri.org/IService1/DeleteCategoryResponse")]
        System.Threading.Tasks.Task DeleteCategoryAsync(int categoryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsCategoryExist", ReplyAction="http://tempuri.org/IService1/IsCategoryExistResponse")]
        bool IsCategoryExist(int categoryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsCategoryExist", ReplyAction="http://tempuri.org/IService1/IsCategoryExistResponse")]
        System.Threading.Tasks.Task<bool> IsCategoryExistAsync(int categoryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllProducts", ReplyAction="http://tempuri.org/IService1/GetAllProductsResponse")]
        WcfService.vwProduct[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllProducts", ReplyAction="http://tempuri.org/IService1/GetAllProductsResponse")]
        System.Threading.Tasks.Task<WcfService.vwProduct[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProduct", ReplyAction="http://tempuri.org/IService1/AddProductResponse")]
        WcfService.vwProduct AddProduct(WcfService.vwProduct product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProduct", ReplyAction="http://tempuri.org/IService1/AddProductResponse")]
        System.Threading.Tasks.Task<WcfService.vwProduct> AddProductAsync(WcfService.vwProduct product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteProduct", ReplyAction="http://tempuri.org/IService1/DeleteProductResponse")]
        void DeleteProduct(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteProduct", ReplyAction="http://tempuri.org/IService1/DeleteProductResponse")]
        System.Threading.Tasks.Task DeleteProductAsync(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsProductExist", ReplyAction="http://tempuri.org/IService1/IsProductExistResponse")]
        bool IsProductExist(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsProductExist", ReplyAction="http://tempuri.org/IService1/IsProductExistResponse")]
        System.Threading.Tasks.Task<bool> IsProductExistAsync(int productID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPayments", ReplyAction="http://tempuri.org/IService1/GetAllPaymentsResponse")]
        WcfService.vwPayment[] GetAllPayments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllPayments", ReplyAction="http://tempuri.org/IService1/GetAllPaymentsResponse")]
        System.Threading.Tasks.Task<WcfService.vwPayment[]> GetAllPaymentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPayment", ReplyAction="http://tempuri.org/IService1/AddPaymentResponse")]
        WcfService.vwPayment AddPayment(WcfService.vwPayment payment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddPayment", ReplyAction="http://tempuri.org/IService1/AddPaymentResponse")]
        System.Threading.Tasks.Task<WcfService.vwPayment> AddPaymentAsync(WcfService.vwPayment payment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePayment", ReplyAction="http://tempuri.org/IService1/DeletePaymentResponse")]
        void DeletePayment(int paymentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeletePayment", ReplyAction="http://tempuri.org/IService1/DeletePaymentResponse")]
        System.Threading.Tasks.Task DeletePaymentAsync(int paymentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsPaymentExist", ReplyAction="http://tempuri.org/IService1/IsPaymentExistResponse")]
        bool IsPaymentExist(int paymentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsPaymentExist", ReplyAction="http://tempuri.org/IService1/IsPaymentExistResponse")]
        System.Threading.Tasks.Task<bool> IsPaymentExistAsync(int paymentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCarriers", ReplyAction="http://tempuri.org/IService1/GetAllCarriersResponse")]
        WcfService.vwCarrier[] GetAllCarriers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCarriers", ReplyAction="http://tempuri.org/IService1/GetAllCarriersResponse")]
        System.Threading.Tasks.Task<WcfService.vwCarrier[]> GetAllCarriersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCarrier", ReplyAction="http://tempuri.org/IService1/AddCarrierResponse")]
        WcfService.vwCarrier AddCarrier(WcfService.vwCarrier carrier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCarrier", ReplyAction="http://tempuri.org/IService1/AddCarrierResponse")]
        System.Threading.Tasks.Task<WcfService.vwCarrier> AddCarrierAsync(WcfService.vwCarrier carrier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCarrier", ReplyAction="http://tempuri.org/IService1/DeleteCarrierResponse")]
        void DeleteCarrier(int carrierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCarrier", ReplyAction="http://tempuri.org/IService1/DeleteCarrierResponse")]
        System.Threading.Tasks.Task DeleteCarrierAsync(int carrierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsCarrierExist", ReplyAction="http://tempuri.org/IService1/IsCarrierExistResponse")]
        bool IsCarrierExist(int carrierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsCarrierExist", ReplyAction="http://tempuri.org/IService1/IsCarrierExistResponse")]
        System.Threading.Tasks.Task<bool> IsCarrierExistAsync(int carrierID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllOrders", ReplyAction="http://tempuri.org/IService1/GetAllOrdersResponse")]
        WcfService.vwOrder[] GetAllOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllOrders", ReplyAction="http://tempuri.org/IService1/GetAllOrdersResponse")]
        System.Threading.Tasks.Task<WcfService.vwOrder[]> GetAllOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddOrder", ReplyAction="http://tempuri.org/IService1/AddOrderResponse")]
        WcfService.vwOrder AddOrder(WcfService.vwOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddOrder", ReplyAction="http://tempuri.org/IService1/AddOrderResponse")]
        System.Threading.Tasks.Task<WcfService.vwOrder> AddOrderAsync(WcfService.vwOrder order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrder", ReplyAction="http://tempuri.org/IService1/DeleteOrderResponse")]
        void DeleteOrder(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrder", ReplyAction="http://tempuri.org/IService1/DeleteOrderResponse")]
        System.Threading.Tasks.Task DeleteOrderAsync(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsOrderExist", ReplyAction="http://tempuri.org/IService1/IsOrderExistResponse")]
        bool IsOrderExist(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsOrderExist", ReplyAction="http://tempuri.org/IService1/IsOrderExistResponse")]
        System.Threading.Tasks.Task<bool> IsOrderExistAsync(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllOrderDetails", ReplyAction="http://tempuri.org/IService1/GetAllOrderDetailsResponse")]
        WcfService.vwOrderDetails[] GetAllOrderDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllOrderDetails", ReplyAction="http://tempuri.org/IService1/GetAllOrderDetailsResponse")]
        System.Threading.Tasks.Task<WcfService.vwOrderDetails[]> GetAllOrderDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddOrderDetails", ReplyAction="http://tempuri.org/IService1/AddOrderDetailsResponse")]
        WcfService.vwOrderDetails AddOrderDetails(WcfService.vwOrderDetails orderDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddOrderDetails", ReplyAction="http://tempuri.org/IService1/AddOrderDetailsResponse")]
        System.Threading.Tasks.Task<WcfService.vwOrderDetails> AddOrderDetailsAsync(WcfService.vwOrderDetails orderDetails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrderDetails", ReplyAction="http://tempuri.org/IService1/DeleteOrderDetailsResponse")]
        void DeleteOrderDetails(int orderDetailsID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrderDetails", ReplyAction="http://tempuri.org/IService1/DeleteOrderDetailsResponse")]
        System.Threading.Tasks.Task DeleteOrderDetailsAsync(int orderDetailsID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsOrderDetailsExist", ReplyAction="http://tempuri.org/IService1/IsOrderDetailsExistResponse")]
        bool IsOrderDetailsExist(int orderDetailsID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IsOrderDetailsExist", ReplyAction="http://tempuri.org/IService1/IsOrderDetailsExistResponse")]
        System.Threading.Tasks.Task<bool> IsOrderDetailsExistAsync(int orderDetailsID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfAgroStoreApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfAgroStoreApp.ServiceReference1.IService1>, WpfAgroStoreApp.ServiceReference1.IService1 {
        
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
        
        public WcfService.vwSupplier[] GetAllSuppliers() {
            return base.Channel.GetAllSuppliers();
        }
        
        public System.Threading.Tasks.Task<WcfService.vwSupplier[]> GetAllSuppliersAsync() {
            return base.Channel.GetAllSuppliersAsync();
        }
        
        public WcfService.vwSupplier AddSupplier(WcfService.vwSupplier supplier) {
            return base.Channel.AddSupplier(supplier);
        }
        
        public System.Threading.Tasks.Task<WcfService.vwSupplier> AddSupplierAsync(WcfService.vwSupplier supplier) {
            return base.Channel.AddSupplierAsync(supplier);
        }
        
        public void DeleteSupplier(int supplierID) {
            base.Channel.DeleteSupplier(supplierID);
        }
        
        public System.Threading.Tasks.Task DeleteSupplierAsync(int supplierID) {
            return base.Channel.DeleteSupplierAsync(supplierID);
        }
        
        public bool IsSupplierExist(int supplierID) {
            return base.Channel.IsSupplierExist(supplierID);
        }
        
        public System.Threading.Tasks.Task<bool> IsSupplierExistAsync(int supplierID) {
            return base.Channel.IsSupplierExistAsync(supplierID);
        }
        
        public WcfService.vwCustomer[] GetAllCustomers() {
            return base.Channel.GetAllCustomers();
        }
        
        public System.Threading.Tasks.Task<WcfService.vwCustomer[]> GetAllCustomersAsync() {
            return base.Channel.GetAllCustomersAsync();
        }
        
        public WcfService.vwCustomer AddCustomer(WcfService.vwCustomer customer) {
            return base.Channel.AddCustomer(customer);
        }
        
        public System.Threading.Tasks.Task<WcfService.vwCustomer> AddCustomerAsync(WcfService.vwCustomer customer) {
            return base.Channel.AddCustomerAsync(customer);
        }
        
        public void DeleteCustomer(int customerID) {
            base.Channel.DeleteCustomer(customerID);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(int customerID) {
            return base.Channel.DeleteCustomerAsync(customerID);
        }
        
        public bool IsCustomerExist(int customerID) {
            return base.Channel.IsCustomerExist(customerID);
        }
        
        public System.Threading.Tasks.Task<bool> IsCustomerExistAsync(int customerID) {
            return base.Channel.IsCustomerExistAsync(customerID);
        }
        
        public WcfService.vwCategory[] GetAllCategories() {
            return base.Channel.GetAllCategories();
        }
        
        public System.Threading.Tasks.Task<WcfService.vwCategory[]> GetAllCategoriesAsync() {
            return base.Channel.GetAllCategoriesAsync();
        }
        
        public WcfService.vwCategory AddCategory(WcfService.vwCategory category) {
            return base.Channel.AddCategory(category);
        }
        
        public System.Threading.Tasks.Task<WcfService.vwCategory> AddCategoryAsync(WcfService.vwCategory category) {
            return base.Channel.AddCategoryAsync(category);
        }
        
        public void DeleteCategory(int categoryID) {
            base.Channel.DeleteCategory(categoryID);
        }
        
        public System.Threading.Tasks.Task DeleteCategoryAsync(int categoryID) {
            return base.Channel.DeleteCategoryAsync(categoryID);
        }
        
        public bool IsCategoryExist(int categoryID) {
            return base.Channel.IsCategoryExist(categoryID);
        }
        
        public System.Threading.Tasks.Task<bool> IsCategoryExistAsync(int categoryID) {
            return base.Channel.IsCategoryExistAsync(categoryID);
        }
        
        public WcfService.vwProduct[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<WcfService.vwProduct[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public WcfService.vwProduct AddProduct(WcfService.vwProduct product) {
            return base.Channel.AddProduct(product);
        }
        
        public System.Threading.Tasks.Task<WcfService.vwProduct> AddProductAsync(WcfService.vwProduct product) {
            return base.Channel.AddProductAsync(product);
        }
        
        public void DeleteProduct(int productID) {
            base.Channel.DeleteProduct(productID);
        }
        
        public System.Threading.Tasks.Task DeleteProductAsync(int productID) {
            return base.Channel.DeleteProductAsync(productID);
        }
        
        public bool IsProductExist(int productID) {
            return base.Channel.IsProductExist(productID);
        }
        
        public System.Threading.Tasks.Task<bool> IsProductExistAsync(int productID) {
            return base.Channel.IsProductExistAsync(productID);
        }
        
        public WcfService.vwPayment[] GetAllPayments() {
            return base.Channel.GetAllPayments();
        }
        
        public System.Threading.Tasks.Task<WcfService.vwPayment[]> GetAllPaymentsAsync() {
            return base.Channel.GetAllPaymentsAsync();
        }
        
        public WcfService.vwPayment AddPayment(WcfService.vwPayment payment) {
            return base.Channel.AddPayment(payment);
        }
        
        public System.Threading.Tasks.Task<WcfService.vwPayment> AddPaymentAsync(WcfService.vwPayment payment) {
            return base.Channel.AddPaymentAsync(payment);
        }
        
        public void DeletePayment(int paymentID) {
            base.Channel.DeletePayment(paymentID);
        }
        
        public System.Threading.Tasks.Task DeletePaymentAsync(int paymentID) {
            return base.Channel.DeletePaymentAsync(paymentID);
        }
        
        public bool IsPaymentExist(int paymentID) {
            return base.Channel.IsPaymentExist(paymentID);
        }
        
        public System.Threading.Tasks.Task<bool> IsPaymentExistAsync(int paymentID) {
            return base.Channel.IsPaymentExistAsync(paymentID);
        }
        
        public WcfService.vwCarrier[] GetAllCarriers() {
            return base.Channel.GetAllCarriers();
        }
        
        public System.Threading.Tasks.Task<WcfService.vwCarrier[]> GetAllCarriersAsync() {
            return base.Channel.GetAllCarriersAsync();
        }
        
        public WcfService.vwCarrier AddCarrier(WcfService.vwCarrier carrier) {
            return base.Channel.AddCarrier(carrier);
        }
        
        public System.Threading.Tasks.Task<WcfService.vwCarrier> AddCarrierAsync(WcfService.vwCarrier carrier) {
            return base.Channel.AddCarrierAsync(carrier);
        }
        
        public void DeleteCarrier(int carrierID) {
            base.Channel.DeleteCarrier(carrierID);
        }
        
        public System.Threading.Tasks.Task DeleteCarrierAsync(int carrierID) {
            return base.Channel.DeleteCarrierAsync(carrierID);
        }
        
        public bool IsCarrierExist(int carrierID) {
            return base.Channel.IsCarrierExist(carrierID);
        }
        
        public System.Threading.Tasks.Task<bool> IsCarrierExistAsync(int carrierID) {
            return base.Channel.IsCarrierExistAsync(carrierID);
        }
        
        public WcfService.vwOrder[] GetAllOrders() {
            return base.Channel.GetAllOrders();
        }
        
        public System.Threading.Tasks.Task<WcfService.vwOrder[]> GetAllOrdersAsync() {
            return base.Channel.GetAllOrdersAsync();
        }
        
        public WcfService.vwOrder AddOrder(WcfService.vwOrder order) {
            return base.Channel.AddOrder(order);
        }
        
        public System.Threading.Tasks.Task<WcfService.vwOrder> AddOrderAsync(WcfService.vwOrder order) {
            return base.Channel.AddOrderAsync(order);
        }
        
        public void DeleteOrder(int orderID) {
            base.Channel.DeleteOrder(orderID);
        }
        
        public System.Threading.Tasks.Task DeleteOrderAsync(int orderID) {
            return base.Channel.DeleteOrderAsync(orderID);
        }
        
        public bool IsOrderExist(int orderID) {
            return base.Channel.IsOrderExist(orderID);
        }
        
        public System.Threading.Tasks.Task<bool> IsOrderExistAsync(int orderID) {
            return base.Channel.IsOrderExistAsync(orderID);
        }
        
        public WcfService.vwOrderDetails[] GetAllOrderDetails() {
            return base.Channel.GetAllOrderDetails();
        }
        
        public System.Threading.Tasks.Task<WcfService.vwOrderDetails[]> GetAllOrderDetailsAsync() {
            return base.Channel.GetAllOrderDetailsAsync();
        }
        
        public WcfService.vwOrderDetails AddOrderDetails(WcfService.vwOrderDetails orderDetails) {
            return base.Channel.AddOrderDetails(orderDetails);
        }
        
        public System.Threading.Tasks.Task<WcfService.vwOrderDetails> AddOrderDetailsAsync(WcfService.vwOrderDetails orderDetails) {
            return base.Channel.AddOrderDetailsAsync(orderDetails);
        }
        
        public void DeleteOrderDetails(int orderDetailsID) {
            base.Channel.DeleteOrderDetails(orderDetailsID);
        }
        
        public System.Threading.Tasks.Task DeleteOrderDetailsAsync(int orderDetailsID) {
            return base.Channel.DeleteOrderDetailsAsync(orderDetailsID);
        }
        
        public bool IsOrderDetailsExist(int orderDetailsID) {
            return base.Channel.IsOrderDetailsExist(orderDetailsID);
        }
        
        public System.Threading.Tasks.Task<bool> IsOrderDetailsExistAsync(int orderDetailsID) {
            return base.Channel.IsOrderDetailsExistAsync(orderDetailsID);
        }
    }
}
