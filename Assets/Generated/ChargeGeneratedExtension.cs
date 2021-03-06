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

        public Charge charge { get { return (Charge)GetComponent(ComponentIds.Charge); } }
        public bool hasCharge { get { return HasComponent(ComponentIds.Charge); } }

        public Entity AddCharge(int newValue) {
            var component = CreateComponent<Charge>(ComponentIds.Charge);
            component.value = newValue;
            return AddComponent(ComponentIds.Charge, component);
        }

        public Entity ReplaceCharge(int newValue) {
            var component = CreateComponent<Charge>(ComponentIds.Charge);
            component.value = newValue;
            ReplaceComponent(ComponentIds.Charge, component);
            return this;
        }

        public Entity RemoveCharge() {
            return RemoveComponent(ComponentIds.Charge);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherCharge;

        public static IMatcher Charge {
            get {
                if(_matcherCharge == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Charge);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherCharge = matcher;
                }

                return _matcherCharge;
            }
        }
    }
}
