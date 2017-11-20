﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfTestLibClient.CallingPatternsRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.mkoit.de/ICallingPatterns", ConfigurationName="CallingPatternsRef.ICallingPatterns", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICallingPatterns {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/DelayedReturn", ReplyAction="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/DelayedReturnResponse")]
        System.DateTime DelayedReturn(int delayInMs);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/DelayedReturn", ReplyAction="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/DelayedReturnResponse")]
        System.IAsyncResult BeginDelayedReturn(int delayInMs, System.AsyncCallback callback, object asyncState);
        
        System.DateTime EndDelayedReturn(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/StartFastAsyncCounter")]
        void StartFastAsyncCounter();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/StartFastAsyncCounter")]
        System.IAsyncResult BeginStartFastAsyncCounter(System.AsyncCallback callback, object asyncState);
        
        void EndStartFastAsyncCounter(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/StopFastAsyncCounter")]
        void StopFastAsyncCounter();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/StopFastAsyncCounter")]
        System.IAsyncResult BeginStopFastAsyncCounter(System.AsyncCallback callback, object asyncState);
        
        void EndStopFastAsyncCounter(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/ResetFastAsyncCounter")]
        void ResetFastAsyncCounter();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/ResetFastAsyncCounter")]
        System.IAsyncResult BeginResetFastAsyncCounter(System.AsyncCallback callback, object asyncState);
        
        void EndResetFastAsyncCounter(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/GetFastAsyncCounterValue", ReplyAction="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/GetFastAsyncCounterValueRes" +
            "ponse")]
        long GetFastAsyncCounterValue();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/GetFastAsyncCounterValue", ReplyAction="http://www.mkoit.de/ICallingPatterns/ICallingPatterns/GetFastAsyncCounterValueRes" +
            "ponse")]
        System.IAsyncResult BeginGetFastAsyncCounterValue(System.AsyncCallback callback, object asyncState);
        
        long EndGetFastAsyncCounterValue(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICallingPatternsChannel : WcfTestLibClient.CallingPatternsRef.ICallingPatterns, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DelayedReturnCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DelayedReturnCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.DateTime Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetFastAsyncCounterValueCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetFastAsyncCounterValueCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public long Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((long)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CallingPatternsClient : System.ServiceModel.ClientBase<WcfTestLibClient.CallingPatternsRef.ICallingPatterns>, WcfTestLibClient.CallingPatternsRef.ICallingPatterns {
        
        private BeginOperationDelegate onBeginDelayedReturnDelegate;
        
        private EndOperationDelegate onEndDelayedReturnDelegate;
        
        private System.Threading.SendOrPostCallback onDelayedReturnCompletedDelegate;
        
        private BeginOperationDelegate onBeginStartFastAsyncCounterDelegate;
        
        private EndOperationDelegate onEndStartFastAsyncCounterDelegate;
        
        private System.Threading.SendOrPostCallback onStartFastAsyncCounterCompletedDelegate;
        
        private BeginOperationDelegate onBeginStopFastAsyncCounterDelegate;
        
        private EndOperationDelegate onEndStopFastAsyncCounterDelegate;
        
        private System.Threading.SendOrPostCallback onStopFastAsyncCounterCompletedDelegate;
        
        private BeginOperationDelegate onBeginResetFastAsyncCounterDelegate;
        
        private EndOperationDelegate onEndResetFastAsyncCounterDelegate;
        
        private System.Threading.SendOrPostCallback onResetFastAsyncCounterCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetFastAsyncCounterValueDelegate;
        
        private EndOperationDelegate onEndGetFastAsyncCounterValueDelegate;
        
        private System.Threading.SendOrPostCallback onGetFastAsyncCounterValueCompletedDelegate;
        
        public CallingPatternsClient() {
        }
        
        public CallingPatternsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CallingPatternsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CallingPatternsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CallingPatternsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<DelayedReturnCompletedEventArgs> DelayedReturnCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> StartFastAsyncCounterCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> StopFastAsyncCounterCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> ResetFastAsyncCounterCompleted;
        
        public event System.EventHandler<GetFastAsyncCounterValueCompletedEventArgs> GetFastAsyncCounterValueCompleted;
        
        public System.DateTime DelayedReturn(int delayInMs) {
            return base.Channel.DelayedReturn(delayInMs);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDelayedReturn(int delayInMs, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDelayedReturn(delayInMs, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.DateTime EndDelayedReturn(System.IAsyncResult result) {
            return base.Channel.EndDelayedReturn(result);
        }
        
        private System.IAsyncResult OnBeginDelayedReturn(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int delayInMs = ((int)(inValues[0]));
            return this.BeginDelayedReturn(delayInMs, callback, asyncState);
        }
        
        private object[] OnEndDelayedReturn(System.IAsyncResult result) {
            System.DateTime retVal = this.EndDelayedReturn(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDelayedReturnCompleted(object state) {
            if ((this.DelayedReturnCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DelayedReturnCompleted(this, new DelayedReturnCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DelayedReturnAsync(int delayInMs) {
            this.DelayedReturnAsync(delayInMs, null);
        }
        
        public void DelayedReturnAsync(int delayInMs, object userState) {
            if ((this.onBeginDelayedReturnDelegate == null)) {
                this.onBeginDelayedReturnDelegate = new BeginOperationDelegate(this.OnBeginDelayedReturn);
            }
            if ((this.onEndDelayedReturnDelegate == null)) {
                this.onEndDelayedReturnDelegate = new EndOperationDelegate(this.OnEndDelayedReturn);
            }
            if ((this.onDelayedReturnCompletedDelegate == null)) {
                this.onDelayedReturnCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDelayedReturnCompleted);
            }
            base.InvokeAsync(this.onBeginDelayedReturnDelegate, new object[] {
                        delayInMs}, this.onEndDelayedReturnDelegate, this.onDelayedReturnCompletedDelegate, userState);
        }
        
        public void StartFastAsyncCounter() {
            base.Channel.StartFastAsyncCounter();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginStartFastAsyncCounter(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginStartFastAsyncCounter(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndStartFastAsyncCounter(System.IAsyncResult result) {
            base.Channel.EndStartFastAsyncCounter(result);
        }
        
        private System.IAsyncResult OnBeginStartFastAsyncCounter(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginStartFastAsyncCounter(callback, asyncState);
        }
        
        private object[] OnEndStartFastAsyncCounter(System.IAsyncResult result) {
            this.EndStartFastAsyncCounter(result);
            return null;
        }
        
        private void OnStartFastAsyncCounterCompleted(object state) {
            if ((this.StartFastAsyncCounterCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.StartFastAsyncCounterCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void StartFastAsyncCounterAsync() {
            this.StartFastAsyncCounterAsync(null);
        }
        
        public void StartFastAsyncCounterAsync(object userState) {
            if ((this.onBeginStartFastAsyncCounterDelegate == null)) {
                this.onBeginStartFastAsyncCounterDelegate = new BeginOperationDelegate(this.OnBeginStartFastAsyncCounter);
            }
            if ((this.onEndStartFastAsyncCounterDelegate == null)) {
                this.onEndStartFastAsyncCounterDelegate = new EndOperationDelegate(this.OnEndStartFastAsyncCounter);
            }
            if ((this.onStartFastAsyncCounterCompletedDelegate == null)) {
                this.onStartFastAsyncCounterCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnStartFastAsyncCounterCompleted);
            }
            base.InvokeAsync(this.onBeginStartFastAsyncCounterDelegate, null, this.onEndStartFastAsyncCounterDelegate, this.onStartFastAsyncCounterCompletedDelegate, userState);
        }
        
        public void StopFastAsyncCounter() {
            base.Channel.StopFastAsyncCounter();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginStopFastAsyncCounter(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginStopFastAsyncCounter(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndStopFastAsyncCounter(System.IAsyncResult result) {
            base.Channel.EndStopFastAsyncCounter(result);
        }
        
        private System.IAsyncResult OnBeginStopFastAsyncCounter(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginStopFastAsyncCounter(callback, asyncState);
        }
        
        private object[] OnEndStopFastAsyncCounter(System.IAsyncResult result) {
            this.EndStopFastAsyncCounter(result);
            return null;
        }
        
        private void OnStopFastAsyncCounterCompleted(object state) {
            if ((this.StopFastAsyncCounterCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.StopFastAsyncCounterCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void StopFastAsyncCounterAsync() {
            this.StopFastAsyncCounterAsync(null);
        }
        
        public void StopFastAsyncCounterAsync(object userState) {
            if ((this.onBeginStopFastAsyncCounterDelegate == null)) {
                this.onBeginStopFastAsyncCounterDelegate = new BeginOperationDelegate(this.OnBeginStopFastAsyncCounter);
            }
            if ((this.onEndStopFastAsyncCounterDelegate == null)) {
                this.onEndStopFastAsyncCounterDelegate = new EndOperationDelegate(this.OnEndStopFastAsyncCounter);
            }
            if ((this.onStopFastAsyncCounterCompletedDelegate == null)) {
                this.onStopFastAsyncCounterCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnStopFastAsyncCounterCompleted);
            }
            base.InvokeAsync(this.onBeginStopFastAsyncCounterDelegate, null, this.onEndStopFastAsyncCounterDelegate, this.onStopFastAsyncCounterCompletedDelegate, userState);
        }
        
        public void ResetFastAsyncCounter() {
            base.Channel.ResetFastAsyncCounter();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginResetFastAsyncCounter(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginResetFastAsyncCounter(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndResetFastAsyncCounter(System.IAsyncResult result) {
            base.Channel.EndResetFastAsyncCounter(result);
        }
        
        private System.IAsyncResult OnBeginResetFastAsyncCounter(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginResetFastAsyncCounter(callback, asyncState);
        }
        
        private object[] OnEndResetFastAsyncCounter(System.IAsyncResult result) {
            this.EndResetFastAsyncCounter(result);
            return null;
        }
        
        private void OnResetFastAsyncCounterCompleted(object state) {
            if ((this.ResetFastAsyncCounterCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ResetFastAsyncCounterCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ResetFastAsyncCounterAsync() {
            this.ResetFastAsyncCounterAsync(null);
        }
        
        public void ResetFastAsyncCounterAsync(object userState) {
            if ((this.onBeginResetFastAsyncCounterDelegate == null)) {
                this.onBeginResetFastAsyncCounterDelegate = new BeginOperationDelegate(this.OnBeginResetFastAsyncCounter);
            }
            if ((this.onEndResetFastAsyncCounterDelegate == null)) {
                this.onEndResetFastAsyncCounterDelegate = new EndOperationDelegate(this.OnEndResetFastAsyncCounter);
            }
            if ((this.onResetFastAsyncCounterCompletedDelegate == null)) {
                this.onResetFastAsyncCounterCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnResetFastAsyncCounterCompleted);
            }
            base.InvokeAsync(this.onBeginResetFastAsyncCounterDelegate, null, this.onEndResetFastAsyncCounterDelegate, this.onResetFastAsyncCounterCompletedDelegate, userState);
        }
        
        public long GetFastAsyncCounterValue() {
            return base.Channel.GetFastAsyncCounterValue();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetFastAsyncCounterValue(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetFastAsyncCounterValue(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public long EndGetFastAsyncCounterValue(System.IAsyncResult result) {
            return base.Channel.EndGetFastAsyncCounterValue(result);
        }
        
        private System.IAsyncResult OnBeginGetFastAsyncCounterValue(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetFastAsyncCounterValue(callback, asyncState);
        }
        
        private object[] OnEndGetFastAsyncCounterValue(System.IAsyncResult result) {
            long retVal = this.EndGetFastAsyncCounterValue(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetFastAsyncCounterValueCompleted(object state) {
            if ((this.GetFastAsyncCounterValueCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetFastAsyncCounterValueCompleted(this, new GetFastAsyncCounterValueCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetFastAsyncCounterValueAsync() {
            this.GetFastAsyncCounterValueAsync(null);
        }
        
        public void GetFastAsyncCounterValueAsync(object userState) {
            if ((this.onBeginGetFastAsyncCounterValueDelegate == null)) {
                this.onBeginGetFastAsyncCounterValueDelegate = new BeginOperationDelegate(this.OnBeginGetFastAsyncCounterValue);
            }
            if ((this.onEndGetFastAsyncCounterValueDelegate == null)) {
                this.onEndGetFastAsyncCounterValueDelegate = new EndOperationDelegate(this.OnEndGetFastAsyncCounterValue);
            }
            if ((this.onGetFastAsyncCounterValueCompletedDelegate == null)) {
                this.onGetFastAsyncCounterValueCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetFastAsyncCounterValueCompleted);
            }
            base.InvokeAsync(this.onBeginGetFastAsyncCounterValueDelegate, null, this.onEndGetFastAsyncCounterValueDelegate, this.onGetFastAsyncCounterValueCompletedDelegate, userState);
        }
    }
}
