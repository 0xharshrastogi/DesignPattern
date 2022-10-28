import { AuthenticationDialog } from "./GUI/AuthenticationDialog";

const dialog = new AuthenticationDialog();

dialog.dialogMode.check();
dialog.loginUserName.updateValue("HarshRastogi");
dialog.loginPassword.updateValue("TEST1234");

console.log(`${dialog}`);
