<p alig="center"><img src="http://assets.devx.com/articlefigs/18878.jpg"</p>

The Command Pattern falls under the category of Behavioural Design Patterns. If you have quite amount of experience in C# particularly WPF, you must have used DelegateCommand or Routed Command or RelayCommands. This internally uses the Command Pattern only. The Command Pattern can be used in any of the projects and we will quicky understand what is it and how to use it in our project.

The Command Pattern encapsulates a request as an object and gives it a known public interface. A request or action is mapped and stored as an object. The Invoker will be ultimately responsible for processing the request. This clearly decouples the request from the invoker. This is more suited for scenarios where we implement Redo, Copy, Paste and Undo operations where the action is stored as an object. We generally use Menu or Shortcut key gestures for any of the preceding actions to be executed.

