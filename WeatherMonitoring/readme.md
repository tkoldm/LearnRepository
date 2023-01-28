Implementation of Observer-pattern from Chapter 2. 

With observer pattern we can create one-to-many relationship between objects and notify observers when state of subject has been changed

With this pattern we can avoid **High Coupling** of classes. We just need use logic how to notify observers.
Subject has list of observers. New observers need to call `subject.RegisterObservers()` and then they will be notified when state of subject changed. When observer don't need to get new updates he can call `subject.removeObserver()` method and, and no new updates will be sent to that observer from that point on.