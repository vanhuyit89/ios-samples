// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_SharedResources.Screens.iPhone.Contacts {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[Foundation.Register("AddressBookScreen")]
	public partial class AddressBookScreen {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIButton __mt_btnAddPhoneNumber;
		
		private UIKit.UIButton __mt_btnSaveChanges;
		
		private UIKit.UITableView __mt_tblPhoneNumbers;
		
		private UIKit.UITextField __mt_txtFirstName;
		
		private UIKit.UITextField __mt_txtLastName;
		
		private UIKit.UITextField __mt_txtPhoneLabel;
		
		private UIKit.UITextField __mt_txtPhoneNumber;
		
		private UIKit.UIScrollView __mt_scrlMain;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("btnAddPhoneNumber")]
		private UIKit.UIButton btnAddPhoneNumber {
			get {
				this.__mt_btnAddPhoneNumber = ((UIKit.UIButton)(this.GetNativeField("btnAddPhoneNumber")));
				return this.__mt_btnAddPhoneNumber;
			}
			set {
				this.__mt_btnAddPhoneNumber = value;
				this.SetNativeField("btnAddPhoneNumber", value);
			}
		}
		
		[Foundation.Connect("btnSaveChanges")]
		private UIKit.UIButton btnSaveChanges {
			get {
				this.__mt_btnSaveChanges = ((UIKit.UIButton)(this.GetNativeField("btnSaveChanges")));
				return this.__mt_btnSaveChanges;
			}
			set {
				this.__mt_btnSaveChanges = value;
				this.SetNativeField("btnSaveChanges", value);
			}
		}
		
		[Foundation.Connect("tblPhoneNumbers")]
		private UIKit.UITableView tblPhoneNumbers {
			get {
				this.__mt_tblPhoneNumbers = ((UIKit.UITableView)(this.GetNativeField("tblPhoneNumbers")));
				return this.__mt_tblPhoneNumbers;
			}
			set {
				this.__mt_tblPhoneNumbers = value;
				this.SetNativeField("tblPhoneNumbers", value);
			}
		}
		
		[Foundation.Connect("txtFirstName")]
		private UIKit.UITextField txtFirstName {
			get {
				this.__mt_txtFirstName = ((UIKit.UITextField)(this.GetNativeField("txtFirstName")));
				return this.__mt_txtFirstName;
			}
			set {
				this.__mt_txtFirstName = value;
				this.SetNativeField("txtFirstName", value);
			}
		}
		
		[Foundation.Connect("txtLastName")]
		private UIKit.UITextField txtLastName {
			get {
				this.__mt_txtLastName = ((UIKit.UITextField)(this.GetNativeField("txtLastName")));
				return this.__mt_txtLastName;
			}
			set {
				this.__mt_txtLastName = value;
				this.SetNativeField("txtLastName", value);
			}
		}
		
		[Foundation.Connect("txtPhoneLabel")]
		private UIKit.UITextField txtPhoneLabel {
			get {
				this.__mt_txtPhoneLabel = ((UIKit.UITextField)(this.GetNativeField("txtPhoneLabel")));
				return this.__mt_txtPhoneLabel;
			}
			set {
				this.__mt_txtPhoneLabel = value;
				this.SetNativeField("txtPhoneLabel", value);
			}
		}
		
		[Foundation.Connect("txtPhoneNumber")]
		private UIKit.UITextField txtPhoneNumber {
			get {
				this.__mt_txtPhoneNumber = ((UIKit.UITextField)(this.GetNativeField("txtPhoneNumber")));
				return this.__mt_txtPhoneNumber;
			}
			set {
				this.__mt_txtPhoneNumber = value;
				this.SetNativeField("txtPhoneNumber", value);
			}
		}
		
		[Foundation.Connect("scrlMain")]
		private UIKit.UIScrollView scrlMain {
			get {
				this.__mt_scrlMain = ((UIKit.UIScrollView)(this.GetNativeField("scrlMain")));
				return this.__mt_scrlMain;
			}
			set {
				this.__mt_scrlMain = value;
				this.SetNativeField("scrlMain", value);
			}
		}
	}
}
