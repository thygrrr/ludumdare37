//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Entity {

        static readonly Poop poopComponent = new Poop();

        public bool isPoop {
            get { return HasComponent(ComponentIds.Poop); }
            set {
                if(value != isPoop) {
                    if(value) {
                        AddComponent(ComponentIds.Poop, poopComponent);
                    } else {
                        RemoveComponent(ComponentIds.Poop);
                    }
                }
            }
        }

        public Entity IsPoop(bool value) {
            isPoop = value;
            return this;
        }
    }

    public partial class Matcher {

        static IMatcher _matcherPoop;

        public static IMatcher Poop {
            get {
                if(_matcherPoop == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Poop);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherPoop = matcher;
                }

                return _matcherPoop;
            }
        }
    }
}