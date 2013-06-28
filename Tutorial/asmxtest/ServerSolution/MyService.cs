// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
// This source code was auto-generated by Web Services Description Language Utility
//Mono Framework v4.0.30319.1
//


/// <remarks/>
[System.Web.Services.WebServiceBinding(Name="MyServiceSoap", Namespace="http://tempuri.org/MyService")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class MyService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback AddOperationCompleted;
    
    private System.Threading.SendOrPostCallback PrintOperationCompleted;
    
    private System.Threading.SendOrPostCallback SetupNNOperationCompleted;
    
    private System.Threading.SendOrPostCallback NextItemOperationCompleted;
    
    private System.Threading.SendOrPostCallback RunNNOperationCompleted;
    
    private System.Threading.SendOrPostCallback RandOperationCompleted;
    
    public MyService() {
        this.Url = "http://localhost:8181/MyService.asmx";
    }
    
    public event AddCompletedEventHandler AddCompleted;
    
    public event PrintCompletedEventHandler PrintCompleted;
    
    public event SetupNNCompletedEventHandler SetupNNCompleted;
    
    public event NextItemCompletedEventHandler NextItemCompleted;
    
    public event RunNNCompletedEventHandler RunNNCompleted;
    
    public event RandCompletedEventHandler RandCompleted;
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MyService/Add", RequestNamespace="http://tempuri.org/MyService", ResponseNamespace="http://tempuri.org/MyService", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public int Add(int a, int b) {
        object[] results = this.Invoke("Add", new object[] {
                    a,
                    b});
        return ((int)(results[0]));
    }
    
    public System.IAsyncResult BeginAdd(int a, int b, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Add", new object[] {
                    a,
                    b}, callback, asyncState);
    }
    
    public int EndAdd(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }
    
    public void AddAsync(int a, int b) {
        this.AddAsync(a, b, null);
    }
    
    public void AddAsync(int a, int b, object userState) {
        if ((this.AddOperationCompleted == null)) {
            this.AddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddCompleted);
        }
        this.InvokeAsync("Add", new object[] {
                    a,
                    b}, this.AddOperationCompleted, userState);
    }
    
    private void OnAddCompleted(object arg) {
        if ((this.AddCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AddCompleted(this, new AddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MyService/Print", RequestNamespace="http://tempuri.org/MyService", ResponseNamespace="http://tempuri.org/MyService", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public void Print() {
        this.Invoke("Print", new object[0]);
    }
    
    public System.IAsyncResult BeginPrint(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Print", new object[0], callback, asyncState);
    }
    
    public void EndPrint(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    public void PrintAsync() {
        this.PrintAsync(null);
    }
    
    public void PrintAsync(object userState) {
        if ((this.PrintOperationCompleted == null)) {
            this.PrintOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPrintCompleted);
        }
        this.InvokeAsync("Print", new object[0], this.PrintOperationCompleted, userState);
    }
    
    private void OnPrintCompleted(object arg) {
        if ((this.PrintCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.PrintCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MyService/SetupNN", RequestNamespace="http://tempuri.org/MyService", ResponseNamespace="http://tempuri.org/MyService", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public void SetupNN() {
        this.Invoke("SetupNN", new object[0]);
    }
    
    public System.IAsyncResult BeginSetupNN(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("SetupNN", new object[0], callback, asyncState);
    }
    
    public void EndSetupNN(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    public void SetupNNAsync() {
        this.SetupNNAsync(null);
    }
    
    public void SetupNNAsync(object userState) {
        if ((this.SetupNNOperationCompleted == null)) {
            this.SetupNNOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetupNNCompleted);
        }
        this.InvokeAsync("SetupNN", new object[0], this.SetupNNOperationCompleted, userState);
    }
    
    private void OnSetupNNCompleted(object arg) {
        if ((this.SetupNNCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SetupNNCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MyService/NextItem", RequestNamespace="http://tempuri.org/MyService", ResponseNamespace="http://tempuri.org/MyService", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public void NextItem() {
        this.Invoke("NextItem", new object[0]);
    }
    
    public System.IAsyncResult BeginNextItem(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("NextItem", new object[0], callback, asyncState);
    }
    
    public void EndNextItem(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
    
    public void NextItemAsync() {
        this.NextItemAsync(null);
    }
    
    public void NextItemAsync(object userState) {
        if ((this.NextItemOperationCompleted == null)) {
            this.NextItemOperationCompleted = new System.Threading.SendOrPostCallback(this.OnNextItemCompleted);
        }
        this.InvokeAsync("NextItem", new object[0], this.NextItemOperationCompleted, userState);
    }
    
    private void OnNextItemCompleted(object arg) {
        if ((this.NextItemCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.NextItemCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MyService/RunNN", RequestNamespace="http://tempuri.org/MyService", ResponseNamespace="http://tempuri.org/MyService", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    [return: System.Xml.Serialization.XmlArrayItem(IsNullable=false)]
    public float[] RunNN(int num1, int num2, int num3) {
        object[] results = this.Invoke("RunNN", new object[] {
                    num1,
                    num2,
                    num3});
        return ((float[])(results[0]));
    }
    
    public System.IAsyncResult BeginRunNN(int num1, int num2, int num3, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("RunNN", new object[] {
                    num1,
                    num2,
                    num3}, callback, asyncState);
    }
    
    public float[] EndRunNN(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((float[])(results[0]));
    }
    
    public void RunNNAsync(int num1, int num2, int num3) {
        this.RunNNAsync(num1, num2, num3, null);
    }
    
    public void RunNNAsync(int num1, int num2, int num3, object userState) {
        if ((this.RunNNOperationCompleted == null)) {
            this.RunNNOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRunNNCompleted);
        }
        this.InvokeAsync("RunNN", new object[] {
                    num1,
                    num2,
                    num3}, this.RunNNOperationCompleted, userState);
    }
    
    private void OnRunNNCompleted(object arg) {
        if ((this.RunNNCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RunNNCompleted(this, new RunNNCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MyService/Rand", RequestNamespace="http://tempuri.org/MyService", ResponseNamespace="http://tempuri.org/MyService", ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped, Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public int Rand(Random r, int max, int min) {
        object[] results = this.Invoke("Rand", new object[] {
                    r,
                    max,
                    min});
        return ((int)(results[0]));
    }
    
    public System.IAsyncResult BeginRand(Random r, int max, int min, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Rand", new object[] {
                    r,
                    max,
                    min}, callback, asyncState);
    }
    
    public int EndRand(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }
    
    public void RandAsync(Random r, int max, int min) {
        this.RandAsync(r, max, min, null);
    }
    
    public void RandAsync(Random r, int max, int min, object userState) {
        if ((this.RandOperationCompleted == null)) {
            this.RandOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRandCompleted);
        }
        this.InvokeAsync("Rand", new object[] {
                    r,
                    max,
                    min}, this.RandOperationCompleted, userState);
    }
    
    private void OnRandCompleted(object arg) {
        if ((this.RandCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.RandCompleted(this, new RandCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/MyService")]
public partial class Random {
}

public partial class AddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal AddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public int Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }
}

public delegate void AddCompletedEventHandler(object sender, AddCompletedEventArgs args);

public delegate void PrintCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);

public delegate void SetupNNCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);

public delegate void NextItemCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs args);

public partial class RunNNCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RunNNCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public float[] Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((float[])(this.results[0]));
        }
    }
}

public delegate void RunNNCompletedEventHandler(object sender, RunNNCompletedEventArgs args);

public partial class RandCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal RandCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    public int Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }
}

public delegate void RandCompletedEventHandler(object sender, RandCompletedEventArgs args);
