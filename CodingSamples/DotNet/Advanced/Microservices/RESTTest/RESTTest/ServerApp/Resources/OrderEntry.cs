namespace ServerApp.Resources;

public readonly record struct OrderEntry(int OrderNo, string OrderDate, string CustomerId, int ProductNo,  int Quantity);
