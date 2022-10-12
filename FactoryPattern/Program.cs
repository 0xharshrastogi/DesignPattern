using FactoryPattern.Logistic;

var logistics = new List<Logistic> { new TruckLogistic(), new ShipLogistic() };

logistics.ForEach(logistic => logistic.StartDelivery());
