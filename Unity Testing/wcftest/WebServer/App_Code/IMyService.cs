using System;
using System.Collections;
using System.ServiceModel;

[ServiceContract]
public interface IMyService {
[OperationContract]
	int Add(int n1, int n2);

}
