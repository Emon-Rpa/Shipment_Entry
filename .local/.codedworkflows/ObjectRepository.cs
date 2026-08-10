using UiPath.CodedWorkflows.DescriptorIntegration;

namespace ShipmentEntry.ObjectRepository
{
    public static class Descriptors
    {
        public static class Chrome_Home_BBLC
        {
            static string _reference = "TL-4uZJJkkyuRJtRBBB__Q/TpOsqOy2JU6TfH_E91O_Lw";
            public static _Implementation._Chrome_Home_BBLC.__Chrome_Home Chrome_Home { get; private set; } = new _Implementation._Chrome_Home_BBLC.__Chrome_Home();
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
        public class __Invoice_Date : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Invoice_Date(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/7nlxeRv0eEmGI39W5hTKyQ",
                    DisplayName = "Invoice Date",
                    Element = this,
                    ParentElement = _parentElementDescriptor,
                    Screen = screenDescriptor
                };
            }
        }
    }

    namespace _Chrome_Home_BBLC._Chrome_Home
    {
        public class __Invoice_No : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;

            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Invoice_No(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition
                {
                    Reference = "TL-4uZJJkkyuRJtRBBB__Q/9iaamMpfGEKWu82MbC7Xwg",
                    DisplayName = "Invoice No",
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
                Invoice_Date = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__Invoice_Date(this, null);
                Invoice_No = new _Implementation._Chrome_Home_BBLC._Chrome_Home.__Invoice_No(this, null);
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
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__Invoice_Date Invoice_Date { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__Invoice_No Invoice_No { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__M_J_Import_Commercial M_J_Import_Commercial { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__Shipment_Details_Button Shipment_Details_Button { get; private set; }
            public _Implementation._Chrome_Home_BBLC._Chrome_Home.__Type_Into_BBLC_No_in_Contact_Book Type_Into_BBLC_No_in_Contact_Book { get; private set; }
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