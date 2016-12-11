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

        static readonly Traveling travelingComponent = new Traveling();

        public bool isTraveling {
            get { return HasComponent(ComponentIds.Traveling); }
            set {
                if(value != isTraveling) {
                    if(value) {
                        AddComponent(ComponentIds.Traveling, travelingComponent);
                    } else {
                        RemoveComponent(ComponentIds.Traveling);
                    }
                }
            }
        }

        public Entity IsTraveling(bool value) {
            isTraveling = value;
            return this;
        }
    }

    public partial class Matcher {

        static IMatcher _matcherTraveling;

        public static IMatcher Traveling {
            get {
                if(_matcherTraveling == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Traveling);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherTraveling = matcher;
                }

                return _matcherTraveling;
            }
        }
    }
}
