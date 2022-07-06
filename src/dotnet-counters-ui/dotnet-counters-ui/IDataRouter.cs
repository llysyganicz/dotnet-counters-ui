using System;

namespace DotnetCountersUi;

public interface IDataRouter
{
  void Start(int pid);
  GraphData Register(string graphId, Action<double> action);
}