using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Dynamic;
using X = ESAPIX.Facade.XContext;

namespace ESAPIX.Facade.Types
{
    public class OptimizationOptionsVMAT : ESAPIX.Facade.Types.OptimizationOptionsBase
    {
        public OptimizationOptionsVMAT() { _client = new ExpandoObject(); }
        public OptimizationOptionsVMAT(dynamic client) { _client = client; }
        public OptimizationOptionsVMAT(ESAPIX.Facade.Types.OptimizationOption startOption, System.String mlcId) { X.Instance.CurrentContext.Thread.Invoke(() => { _client = VMSConstructor.ConstructOptimizationOptionsVMAT(startOption, mlcId); }); }
        public OptimizationOptionsVMAT(ESAPIX.Facade.Types.OptimizationIntermediateDoseOption intermediateDoseOption, System.String mlcId) { X.Instance.CurrentContext.Thread.Invoke(() => { _client = VMSConstructor.ConstructOptimizationOptionsVMAT(intermediateDoseOption, mlcId); }); }
        public OptimizationOptionsVMAT(System.Int32 numberOfCycles, System.String mlcId) { X.Instance.CurrentContext.Thread.Invoke(() => { _client = VMSConstructor.ConstructOptimizationOptionsVMAT(numberOfCycles, mlcId); }); }
        public OptimizationOptionsVMAT(ESAPIX.Facade.Types.OptimizationOption startOption, ESAPIX.Facade.Types.OptimizationIntermediateDoseOption intermediateDoseOption, System.Int32 numberOfCycles, System.String mlcId) { X.Instance.CurrentContext.Thread.Invoke(() => { _client = VMSConstructor.ConstructOptimizationOptionsVMAT(startOption, intermediateDoseOption, numberOfCycles, mlcId); }); }
        public OptimizationOptionsVMAT(ESAPIX.Facade.Types.OptimizationOptionsVMAT options) { X.Instance.CurrentContext.Thread.Invoke(() => { _client = VMSConstructor.ConstructOptimizationOptionsVMAT(options); }); }
        public System.Int32 NumberOfOptimizationCycles
        {
            get
            {
                if (_client is ExpandoObject) { return _client.NumberOfOptimizationCycles; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Int32>((sc) => { return local._client.NumberOfOptimizationCycles; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.NumberOfOptimizationCycles = value; }
            }
        }
    }
}