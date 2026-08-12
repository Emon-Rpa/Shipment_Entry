using UiPath.CodedWorkflows.DescriptorIntegration;

namespace ShipmentEntry.ObjectRepository
{
    public static class Descriptors
    {
        public static class Chrome_Home_BBLC
        {
            static string _reference = "TL-4uZJJkkyuRJtRBBB__Q/TpOsqOy2JU6TfH_E91O_Lw";
            public static _Implementation._Chrome_Home_BBLC.__Chrome_Home Chrome_Home { get; private set; } = new _Implementation._Chrome_Home_BBLC.__Chrome_Home();
            public static _Implementation._Chrome_Home_BBLC.__Shipment_Create Shipment_Create { get; private set; } = new _Implementation._Chrome_Home_BBLC.__Shipment_Create();
        }

        public static class Chrome_Home_LCM_User
        {
            static string _reference = "TL-4uZJJkkyuRJtRBBB__Q/IX9bEzzcw0OHW-Vu0-7RVg";
            public static _Implementation._Chrome_Home_LCM_User.__Chrome_Home Chrome_Home { get; private set; } = new _Implementation._Chrome_Home_LCM_User.__Chrome_Home();
        }
    }
}

namespace ShipmentEntry._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }
        public string Reference { get; set; }
        public string DisplayName { get; set; }
        public IElementDescriptor ParentElement { get; set; }
        public IElementDescriptor Element { get; set; }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __Alert_Ok : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Alert_Ok(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/O2WNvKUboEOUsD_lxnK76A",
                    DisplayName = "Alert Ok",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __BBLC_NO_Field : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __BBLC_NO_Field(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/bVYmMM97VkOdpSXE1qsSTQ",
                    DisplayName = "BBLC NO Field",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __BBLC_V2 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __BBLC_V2(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/fw9wQ_2kp06vp1u2rsnH2w",
                    DisplayName = "BBLC V2",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __BBLC_Information_Exist : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __BBLC_Information_Exist(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/QALuEg5orUGfo7DYA67EHg",
                    DisplayName = "BBLC-Information-Exist",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __Contact_No_Exist_containing_BBLC_NO : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Contact_No_Exist_containing_BBLC_NO(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/zLSUEA5BEUytUO8sQynWiQ",
                    DisplayName = "Contact No Exist containing BBLC NO",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __Create_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Create_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/lhZyvART8Uux6Q34lJJYqg",
                    DisplayName = "Create Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __HOME : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __HOME(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Rmg18I0cNESw5nHNlIoZgA",
                    DisplayName = "HOME",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __M_J_Import_Commercial : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __M_J_Import_Commercial(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/jmr59n1sLESPO93XOZCUZA",
                    DisplayName = "M&J Import Commercial",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __Shipment_Details_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Shipment_Details_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/VGv-IPTsxUu_ZZoEnqGY6A",
                    DisplayName = "Shipment Details Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __Type_Into_BBLC_No_in_Contact_Book : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Type_Into_BBLC_No_in_Contact_Book(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/ziRuK4ZqMkisgFG69mUPPQ",
                    DisplayName = "Type Into BBLC No in Contact Book",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC
    {
        public class __Chrome_Home : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Home()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/XFtzSPMQR0uBAtd63K8sOA",
                    DisplayName = "Chrome Home",
                    Screen = this
                };
                Alert_Ok = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__Alert_Ok(this, null);
                BBLC_NO_Field = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__BBLC_NO_Field(this, null);
                BBLC_V2 = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__BBLC_V2(this, null);
                BBLC_Information_Exist = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__BBLC_Information_Exist(this, null);
                Contact_No_Exist_containing_BBLC_NO = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__Contact_No_Exist_containing_BBLC_NO(this, null);
                Create_Button = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__Create_Button(this, null);
                HOME = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__HOME(this, null);
                M_J_Import_Commercial = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__M_J_Import_Commercial(this, null);
                Shipment_Details_Button = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__Shipment_Details_Button(this, null);
                Type_Into_BBLC_No_in_Contact_Book = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__Type_Into_BBLC_No_in_Contact_Book(this, null);
            }

            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__Alert_Ok Alert_Ok { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__BBLC_NO_Field BBLC_NO_Field { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__BBLC_V2 BBLC_V2 { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__BBLC_Information_Exist BBLC_Information_Exist { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__Contact_No_Exist_containing_BBLC_NO Contact_No_Exist_containing_BBLC_NO { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__Create_Button Create_Button { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__HOME HOME { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__M_J_Import_Commercial M_J_Import_Commercial { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__Shipment_Details_Button Shipment_Details_Button { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__Type_Into_BBLC_No_in_Contact_Book Type_Into_BBLC_No_in_Contact_Book { get; private set; }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_10_Fill_Shipment_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_10_Fill_Shipment_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/VbGdk7vt8kSa6rgxxC8i0A",
                    DisplayName = "6.10_Fill Shipment Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_11_Shipment_NO : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_11_Shipment_NO(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/H39Ojp1npUyTyq2bHVmbBw",
                    DisplayName = "6.11_Shipment NO",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_12_Shipment_No_OK_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_12_Shipment_No_OK_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/2g40c8epG0aju_i4npMvFA",
                    DisplayName = "6.12_Shipment No OK Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_13_14_Freight_Cost_Flag : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_13_14_Freight_Cost_Flag(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/NRUJ_1Fi50azEnD-q3kOgw",
                    DisplayName = "6.13+14_Freight Cost Flag",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_15_Freight_Cost : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_15_Freight_Cost(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/euG6HxXJz0eyw4SHDZJItg",
                    DisplayName = "6.15_Freight Cost",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_16_Other_Charges : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_16_Other_Charges(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/yeV5ZuVuaEmvxKzT8FOPGQ",
                    DisplayName = "6.16_Other Charges",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_17_No_Of_Packages : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_17_No_Of_Packages(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/0x21Aeeqp0KWKXbsUBt5QA",
                    DisplayName = "6.17 No Of Packages",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_18_UOM : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_18_UOM(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/_ratmlnKSkGgv4uVE04E_Q",
                    DisplayName = "6.18_UOM",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_20_Port_Of_Landing : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_20_Port_Of_Landing(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/DlhaeL-SwUSOKxwGt5mZlw",
                    DisplayName = "6.20_Port Of Landing",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_22_23_Port_Of_Discharge : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_22_23_Port_Of_Discharge(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Lj4PIgdOqEq0xbc8MY4s5g",
                    DisplayName = "6.22+23_Port Of Discharge",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_25_Nn_Copy_Rcvd_Date : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_25_Nn_Copy_Rcvd_Date(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/b9TpkmD-B0KUChf9ms4zAA",
                    DisplayName = "6.25_Nn Copy Rcvd Date",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_26_27_Endorsement : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_26_27_Endorsement(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/gtU71ICpQUqIrJg8hYLYzQ",
                    DisplayName = "6.26+27_Endorsement",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_28_M_vseel_Voyage_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_28_M_vseel_Voyage_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/9OlLyeRJrU6co1a9Zb6rTg",
                    DisplayName = "6.28_M vseel Voyage\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_2Invoice_No : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_2Invoice_No(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Wf3B62pUhE2J_mMsiEWlqA",
                    DisplayName = "6.2Invoice No",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_30_Add_Container_No_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_30_Add_Container_No_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/9O3K6Eq9OEK_gh6PvtnIYQ",
                    DisplayName = "6.30_Add Container No Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_31_Create_Button_in_Add_Container_No : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_31_Create_Button_in_Add_Container_No(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/3HF_9MVkdkyR2QmqyUStCA",
                    DisplayName = "6.31_Create Button in Add Container No",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_33_Container_No_Under_Create : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_33_Container_No_Under_Create(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Gqv57SfNeECpAdRRZ2fi-w",
                    DisplayName = "6.33_Container No Under Create",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_34_Container_Size_Dropdown_Under_Create : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_34_Container_Size_Dropdown_Under_Create(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/QU8USTuA8kmQFgK-ncqi7Q",
                    DisplayName = "6.34_Container Size Dropdown Under Create",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_37_Container_No_OK_Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_37_Container_No_OK_Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/QwJLM2IzXEa4RCOOl2a_Ug",
                    DisplayName = "6.37_Container No OK Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_39_40_Container_Status : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_39_40_Container_Status(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/HYptQuG2Sk6xK0vDgLCfXA",
                    DisplayName = "6.39+40_Container Status",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_3Invoice_Date : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_3Invoice_Date(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/-_rIbl4NDUOeEAE7CSRtIg",
                    DisplayName = "6.3Invoice Date",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_4_5_Shipment_Status : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_4_5_Shipment_Status(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/8KPwCqyQ8kqFzNp9McNVtg",
                    DisplayName = "6.4+5_Shipment Status",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_42_Weight : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_42_Weight(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Woh1H8WA9UOe6xZzTcFxLw",
                    DisplayName = "6.42_Weight",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_44_Cbm : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_44_Cbm(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/aCoCudefsUS6hRHPb2scRw",
                    DisplayName = "6.44_Cbm",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_46_Transport_Doc_No : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_46_Transport_Doc_No(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/2BV2wZawFUWucvzgaiyedw",
                    DisplayName = "6.46_Transport Doc No",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_49_Transport_Doc_No_Date : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_49_Transport_Doc_No_Date(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/L3mzvjFzmUKkd5fNVKCSWA",
                    DisplayName = "6.49 Transport Doc No Date",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_50_C___F_Agent_Name : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_50_C___F_Agent_Name(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/xxKa2EOka0G4C3xOBz7s8g",
                    DisplayName = "6.50 C & F Agent Name",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_51_Courier_Name__B2B_Dox_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_51_Courier_Name__B2B_Dox_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/8jK6wlFqsk2GKKmYI4FzHg",
                    DisplayName = "6.51 Courier Name (B2B Dox)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_53_ETD__ORIGIN_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_53_ETD__ORIGIN_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/rr4Lrlp4NEO2aBMqy22_UQ",
                    DisplayName = "6.53 ETD (ORIGIN)",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_54_type_into__ATD__ORIGIN__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_54_type_into__ATD__ORIGIN__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/s8rIvmoJIUqeBp19imSZYA",
                    DisplayName = "6.54 type into \"ATD (ORIGIN)\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_55_56_Select_item__Bill_of_Exchange_Available_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_55_56_Select_item__Bill_of_Exchange_Available_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/fhgyD0xKXU-KaHsVODxP0w",
                    DisplayName = "6.55+56 Select item \"Bill of Exchange Available\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_58_Type_into__Shipment_from_Country_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_58_Type_into__Shipment_from_Country_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/k4kO_l0zdUiVlTg3u7_D1w",
                    DisplayName = "6.58 Type into \"Shipment from Country\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_6_7_Shipment_Mode : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_6_7_Shipment_Mode(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/-x7QFjWLdkWTvTU9RnHzzA",
                    DisplayName = "6.6+7_Shipment Mode",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_60_Type_into__Forwarder_Name_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_60_Type_into__Forwarder_Name_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/GE5wJOC15EOLdEwwgotx7Q",
                    DisplayName = "6.60 Type into \"Forwarder Name\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_62_Type_into__Carrier_Name_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_62_Type_into__Carrier_Name_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Ce3439kIiU6KQ1a7J-DNNg",
                    DisplayName = "6.62 Type into \"Carrier Name\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_
    {
        public class ___6_65_Click_on__Create__in__Generate___Apply__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_65_Click_on__Create__in__Generate___Apply__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Cut-CIg130G1OdjMokSNRA",
                    DisplayName = "6.65 Click on \"Create\" in \"Generate & Apply \"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_
    {
        public class ___6_66_Type_into__Shipment_Num_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_66_Type_into__Shipment_Num_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/ExQpDwjZ0ke9rY7RVlZ8Mg",
                    DisplayName = "6.66 Type into \"Shipment Num\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_
    {
        public class ___6_67_Type_into__First_Shipment_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_67_Type_into__First_Shipment_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/fqGU5cWpKk-34iQlugWAzA",
                    DisplayName = "6.67 Type into \"First Shipment\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_
    {
        public class ___6_69_Click_on__Ok__Button_in_Generate_Shippment : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_69_Click_on__Ok__Button_in_Generate_Shippment(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/rhzBEsKbwk69dT_aR1SV1w",
                    DisplayName = "6.69 Click on \"Ok\" Button in Generate Shippment",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.__6_71_Click_on__Generate_changes_
    {
        public class ___6_72_Click_on__Process_Lines_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_72_Click_on__Process_Lines_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/j8EhaxMrk02Ndg4kJFJYcA",
                    DisplayName = "6.72 Click on \"Process Lines\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.__6_71_Click_on__Generate_changes_
    {
        public class ___6_73_Click_on__Blank_Space_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_73_Click_on__Blank_Space_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/alfuqWcSpkWZqt_aZ3982Q",
                    DisplayName = "6.73 Click on \"Blank Space\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_
    {
        public class ___6_71_Click_on__Generate_changes_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_71_Click_on__Generate_changes_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/iEojLtVJ80m5F2DE021_eQ",
                    DisplayName = "6.71 Click on \"Generate changes\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
                _6_72_Click_on__Process_Lines_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.__6_71_Click_on__Generate_changes_.___6_72_Click_on__Process_Lines_(screenDescriptor, this);
                _6_73_Click_on__Blank_Space_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.__6_71_Click_on__Generate_changes_.___6_73_Click_on__Blank_Space_(screenDescriptor, this);
            }

            public _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.__6_71_Click_on__Generate_changes_.___6_72_Click_on__Process_Lines_ _6_72_Click_on__Process_Lines_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.__6_71_Click_on__Generate_changes_.___6_73_Click_on__Blank_Space_ _6_73_Click_on__Blank_Space_ { get; private set; }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_
    {
        public class ___6_74_Click_on__save__Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_74_Click_on__save__Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/M5j7xjTdskSoLSZETSRrrQ",
                    DisplayName = "6.74 Click on \"save\" Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_
    {
        public class ___6_75_Click_on__Close__Button : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_75_Click_on__Close__Button(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/GjqraEqzPUG3N7T-TWSdNg",
                    DisplayName = "6.75 Click on \"Close\" Button",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_64_Click_on__Generate___Apply_Changes_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_64_Click_on__Generate___Apply_Changes_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/-yahl9AQGU-Y7NJSjs1lWQ",
                    DisplayName = "6.64 Click on \"Generate & Apply Changes\"",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
                _6_65_Click_on__Create__in__Generate___Apply__ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_65_Click_on__Create__in__Generate___Apply__(screenDescriptor, this);
                _6_66_Type_into__Shipment_Num_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_66_Type_into__Shipment_Num_(screenDescriptor, this);
                _6_67_Type_into__First_Shipment_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_67_Type_into__First_Shipment_(screenDescriptor, this);
                _6_69_Click_on__Ok__Button_in_Generate_Shippment = new _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_69_Click_on__Ok__Button_in_Generate_Shippment(screenDescriptor, this);
                _6_71_Click_on__Generate_changes_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_71_Click_on__Generate_changes_(screenDescriptor, this);
                _6_74_Click_on__save__Button = new _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_74_Click_on__save__Button(screenDescriptor, this);
                _6_75_Click_on__Close__Button = new _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_75_Click_on__Close__Button(screenDescriptor, this);
            }

            public _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_65_Click_on__Create__in__Generate___Apply__ _6_65_Click_on__Create__in__Generate___Apply__ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_66_Type_into__Shipment_Num_ _6_66_Type_into__Shipment_Num_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_67_Type_into__First_Shipment_ _6_67_Type_into__First_Shipment_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_69_Click_on__Ok__Button_in_Generate_Shippment _6_69_Click_on__Ok__Button_in_Generate_Shippment { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_71_Click_on__Generate_changes_ _6_71_Click_on__Generate_changes_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_74_Click_on__save__Button _6_74_Click_on__save__Button { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.__6_64_Click_on__Generate___Apply_Changes_.___6_75_Click_on__Close__Button _6_75_Click_on__Close__Button { get; private set; }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_8___6_63_SAVE : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_8___6_63_SAVE(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/kJT2Nrj_-0yB2E9WAUEhHw",
                    DisplayName = "6.8 & 6.63_SAVE",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Shipment_Create
    {
        public class ___6_9_Information_OK : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6_9_Information_OK(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/-YPOxsDrRUes2RvW3ZNdoQ",
                    DisplayName = "6.9 Information OK",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC
    {
        public class __Shipment_Create : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Shipment_Create()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Q5mPReDU4kOsLvpdjOoAOQ",
                    DisplayName = "Shipment Create",
                    Screen = this
                };
                _6_10_Fill_Shipment_Button = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_10_Fill_Shipment_Button(this, null);
                _6_11_Shipment_NO = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_11_Shipment_NO(this, null);
                _6_12_Shipment_No_OK_Button = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_12_Shipment_No_OK_Button(this, null);
                _6_13_14_Freight_Cost_Flag = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_13_14_Freight_Cost_Flag(this, null);
                _6_15_Freight_Cost = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_15_Freight_Cost(this, null);
                _6_16_Other_Charges = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_16_Other_Charges(this, null);
                _6_17_No_Of_Packages = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_17_No_Of_Packages(this, null);
                _6_18_UOM = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_18_UOM(this, null);
                _6_20_Port_Of_Landing = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_20_Port_Of_Landing(this, null);
                _6_22_23_Port_Of_Discharge = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_22_23_Port_Of_Discharge(this, null);
                _6_25_Nn_Copy_Rcvd_Date = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_25_Nn_Copy_Rcvd_Date(this, null);
                _6_26_27_Endorsement = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_26_27_Endorsement(this, null);
                _6_28_M_vseel_Voyage_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_28_M_vseel_Voyage_(this, null);
                _6_2Invoice_No = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_2Invoice_No(this, null);
                _6_30_Add_Container_No_Button = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_30_Add_Container_No_Button(this, null);
                _6_31_Create_Button_in_Add_Container_No = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_31_Create_Button_in_Add_Container_No(this, null);
                _6_33_Container_No_Under_Create = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_33_Container_No_Under_Create(this, null);
                _6_34_Container_Size_Dropdown_Under_Create = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_34_Container_Size_Dropdown_Under_Create(this, null);
                _6_37_Container_No_OK_Button = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_37_Container_No_OK_Button(this, null);
                _6_39_40_Container_Status = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_39_40_Container_Status(this, null);
                _6_3Invoice_Date = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_3Invoice_Date(this, null);
                _6_4_5_Shipment_Status = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_4_5_Shipment_Status(this, null);
                _6_42_Weight = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_42_Weight(this, null);
                _6_44_Cbm = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_44_Cbm(this, null);
                _6_46_Transport_Doc_No = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_46_Transport_Doc_No(this, null);
                _6_49_Transport_Doc_No_Date = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_49_Transport_Doc_No_Date(this, null);
                _6_50_C___F_Agent_Name = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_50_C___F_Agent_Name(this, null);
                _6_51_Courier_Name__B2B_Dox_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_51_Courier_Name__B2B_Dox_(this, null);
                _6_53_ETD__ORIGIN_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_53_ETD__ORIGIN_(this, null);
                _6_54_type_into__ATD__ORIGIN__ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_54_type_into__ATD__ORIGIN__(this, null);
                _6_55_56_Select_item__Bill_of_Exchange_Available_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_55_56_Select_item__Bill_of_Exchange_Available_(this, null);
                _6_58_Type_into__Shipment_from_Country_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_58_Type_into__Shipment_from_Country_(this, null);
                _6_6_7_Shipment_Mode = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_6_7_Shipment_Mode(this, null);
                _6_60_Type_into__Forwarder_Name_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_60_Type_into__Forwarder_Name_(this, null);
                _6_62_Type_into__Carrier_Name_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_62_Type_into__Carrier_Name_(this, null);
                _6_64_Click_on__Generate___Apply_Changes_ = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_64_Click_on__Generate___Apply_Changes_(this, null);
                _6_8___6_63_SAVE = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_8___6_63_SAVE(this, null);
                _6_9_Information_OK = new _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_9_Information_OK(this, null);
            }

            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_10_Fill_Shipment_Button _6_10_Fill_Shipment_Button { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_11_Shipment_NO _6_11_Shipment_NO { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_12_Shipment_No_OK_Button _6_12_Shipment_No_OK_Button { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_13_14_Freight_Cost_Flag _6_13_14_Freight_Cost_Flag { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_15_Freight_Cost _6_15_Freight_Cost { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_16_Other_Charges _6_16_Other_Charges { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_17_No_Of_Packages _6_17_No_Of_Packages { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_18_UOM _6_18_UOM { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_20_Port_Of_Landing _6_20_Port_Of_Landing { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_22_23_Port_Of_Discharge _6_22_23_Port_Of_Discharge { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_25_Nn_Copy_Rcvd_Date _6_25_Nn_Copy_Rcvd_Date { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_26_27_Endorsement _6_26_27_Endorsement { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_28_M_vseel_Voyage_ _6_28_M_vseel_Voyage_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_2Invoice_No _6_2Invoice_No { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_30_Add_Container_No_Button _6_30_Add_Container_No_Button { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_31_Create_Button_in_Add_Container_No _6_31_Create_Button_in_Add_Container_No { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_33_Container_No_Under_Create _6_33_Container_No_Under_Create { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_34_Container_Size_Dropdown_Under_Create _6_34_Container_Size_Dropdown_Under_Create { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_37_Container_No_OK_Button _6_37_Container_No_OK_Button { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_39_40_Container_Status _6_39_40_Container_Status { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_3Invoice_Date _6_3Invoice_Date { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_4_5_Shipment_Status _6_4_5_Shipment_Status { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_42_Weight _6_42_Weight { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_44_Cbm _6_44_Cbm { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_46_Transport_Doc_No _6_46_Transport_Doc_No { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_49_Transport_Doc_No_Date _6_49_Transport_Doc_No_Date { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_50_C___F_Agent_Name _6_50_C___F_Agent_Name { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_51_Courier_Name__B2B_Dox_ _6_51_Courier_Name__B2B_Dox_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_53_ETD__ORIGIN_ _6_53_ETD__ORIGIN_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_54_type_into__ATD__ORIGIN__ _6_54_type_into__ATD__ORIGIN__ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_55_56_Select_item__Bill_of_Exchange_Available_ _6_55_56_Select_item__Bill_of_Exchange_Available_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_58_Type_into__Shipment_from_Country_ _6_58_Type_into__Shipment_from_Country_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_6_7_Shipment_Mode _6_6_7_Shipment_Mode { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_60_Type_into__Forwarder_Name_ _6_60_Type_into__Forwarder_Name_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_62_Type_into__Carrier_Name_ _6_62_Type_into__Carrier_Name_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_64_Click_on__Generate___Apply_Changes_ _6_64_Click_on__Generate___Apply_Changes_ { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_8___6_63_SAVE _6_8___6_63_SAVE { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Shipment_Create.___6_9_Information_OK _6_9_Information_OK { get; private set; }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Alert_Ok : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Alert_Ok(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/I4woJ05ROU6U5eZ7GLOYuA",
                    DisplayName = "Alert Ok",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __ALL_LCM_User : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ALL_LCM_User(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/qz9UPxX8pEWsRd2cRgA-Cg",
                    DisplayName = "ALL-LCM User",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Check_Box_Shipment_Lines : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Check_Box_Shipment_Lines(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/HchZjclYYkODA7d4baXbTQ",
                    DisplayName = "Check Box Shipment Lines",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Click__ALL_LCM_User_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__ALL_LCM_User_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/C0yEP-6TkkS0hu_5v13dlQ",
                    DisplayName = "Click 'ALL-LCM User'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Click__HOME_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__HOME_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/QlzLLYwoIUaG070sP2V4_A",
                    DisplayName = "Click 'HOME'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Click__Shipments_in_Landed_cost_Managements_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__Shipments_in_Landed_cost_Managements_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/AFGdpXeTAkai2z_eHkB9Ig",
                    DisplayName = "Click 'Shipments in Landed cost Managements'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Click__Shipments_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__Shipments_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/ABg8H3Xku0KGbL2OTk4skA",
                    DisplayName = "Click 'Shipments'",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __CREATE : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __CREATE(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/4igorVGM40WOGcpJNVQ_Hw",
                    DisplayName = "CREATE",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Enter_Purchase_Order : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Enter_Purchase_Order(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/k1VrenzdNUyjnr8DnNyS3Q",
                    DisplayName = "Enter Purchase Order",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Get_Created_Shipment_No : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Get_Created_Shipment_No(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Fr2YPsvvmkq7zMUZgmnQTw",
                    DisplayName = "Get Created Shipment No",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __GO : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __GO(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/K5CVKx_ZOkG_Ohtlk4xXtg",
                    DisplayName = "GO",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __GO_LINES : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __GO_LINES(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/eVUShDdukEayTjm16-zetQ",
                    DisplayName = "GO LINES",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Go_Under_Lines : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Go_Under_Lines(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/cpRQSU2TJUaD_iDsSHyZFQ",
                    DisplayName = "Go Under Lines",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __HOME : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __HOME(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/c72FOVh0E0mRfHF2lYeuLg",
                    DisplayName = "HOME",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Inventory_Organization : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Inventory_Organization(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/hndtUl0x302xUdJ5LOrR7A",
                    DisplayName = "Inventory Organization",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Inventory_Organization_Title : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Inventory_Organization_Title(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/8EJc8jA7UUiwQN639s4WBQ",
                    DisplayName = "Inventory Organization Title",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Line_Action_Dropdown : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Line_Action_Dropdown(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/sJU6164vq0yDTCBTv288mQ",
                    DisplayName = "Line Action Dropdown",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Lines : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Lines(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/UNL8RCmDZEuR6iwoR38hVw",
                    DisplayName = "Lines",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Lines_Apply : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Lines_Apply(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/NkS_Lz5BcEOnKDIWGESZRQ",
                    DisplayName = "Lines Apply",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __OK : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __OK(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/Hx0hKsc0E0KlgBnRi6zGkA",
                    DisplayName = "OK",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Operating_Unit_Text_Box : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Operating_Unit_Text_Box(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/qlQuQQGYPEqbN4dz_V6HsA",
                    DisplayName = "Operating Unit Text Box",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Save : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Save(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/8gxqei9uDkOCml9a_JWSIg",
                    DisplayName = "Save",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Shipment_Type : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Shipment_Type(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/479gTPtVw0SCoFD9qN8seg",
                    DisplayName = "Shipment Type",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Shipments : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Shipments(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/S9eAx3jMBUqvXWjp-YNdTQ",
                    DisplayName = "Shipments",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Third_Party_Name : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Third_Party_Name(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/rc5KCsh_vEGcF5LO9sU86Q",
                    DisplayName = "Third Party Name",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User._Chrome_Home
    {
        public class __Third_Party_Site : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Third_Party_Site(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/NBpo1V3f2UO1d5hD0IZL_A",
                    DisplayName = "Third Party Site",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_LCM_User
    {
        public class __Chrome_Home : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;

            public __Chrome_Home()
            {
                _screenDescriptor = new ScreenDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/ABsL-kEkLkix5GR01q7CXw",
                    DisplayName = "Chrome Home",
                    Screen = this
                };
                Alert_Ok = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Alert_Ok(this, null);
                ALL_LCM_User = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__ALL_LCM_User(this, null);
                Check_Box_Shipment_Lines = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Check_Box_Shipment_Lines(this, null);
                Click__ALL_LCM_User_ = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Click__ALL_LCM_User_(this, null);
                Click__HOME_ = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Click__HOME_(this, null);
                Click__Shipments_in_Landed_cost_Managements_ = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Click__Shipments_in_Landed_cost_Managements_(this, null);
                Click__Shipments_ = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Click__Shipments_(this, null);
                CREATE = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__CREATE(this, null);
                Enter_Purchase_Order = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Enter_Purchase_Order(this, null);
                Get_Created_Shipment_No = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Get_Created_Shipment_No(this, null);
                GO = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__GO(this, null);
                GO_LINES = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__GO_LINES(this, null);
                Go_Under_Lines = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Go_Under_Lines(this, null);
                HOME = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__HOME(this, null);
                Inventory_Organization = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Inventory_Organization(this, null);
                Inventory_Organization_Title = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Inventory_Organization_Title(this, null);
                Line_Action_Dropdown = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Line_Action_Dropdown(this, null);
                Lines = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Lines(this, null);
                Lines_Apply = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Lines_Apply(this, null);
                OK = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__OK(this, null);
                Operating_Unit_Text_Box = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Operating_Unit_Text_Box(this, null);
                Save = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Save(this, null);
                Shipment_Type = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Shipment_Type(this, null);
                Shipments = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Shipments(this, null);
                Third_Party_Name = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Third_Party_Name(this, null);
                Third_Party_Site = new _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Third_Party_Site(this, null);
            }

            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Alert_Ok Alert_Ok { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__ALL_LCM_User ALL_LCM_User { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Check_Box_Shipment_Lines Check_Box_Shipment_Lines { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Click__ALL_LCM_User_ Click__ALL_LCM_User_ { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Click__HOME_ Click__HOME_ { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Click__Shipments_in_Landed_cost_Managements_ Click__Shipments_in_Landed_cost_Managements_ { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Click__Shipments_ Click__Shipments_ { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__CREATE CREATE { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Enter_Purchase_Order Enter_Purchase_Order { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Get_Created_Shipment_No Get_Created_Shipment_No { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__GO GO { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__GO_LINES GO_LINES { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Go_Under_Lines Go_Under_Lines { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__HOME HOME { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Inventory_Organization Inventory_Organization { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Inventory_Organization_Title Inventory_Organization_Title { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Line_Action_Dropdown Line_Action_Dropdown { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Lines Lines { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Lines_Apply Lines_Apply { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__OK OK { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Operating_Unit_Text_Box Operating_Unit_Text_Box { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Save Save { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Shipment_Type Shipment_Type { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Shipments Shipments { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Third_Party_Name Third_Party_Name { get; private set; }
            public _Implementation._Chrome_Home_LCM_User._Chrome_Home.__Third_Party_Site Third_Party_Site { get; private set; }
        }
    }
}