import { Component } from '@angular/core';
import { AssetService } from '../../_services/AssetService';

@Component({
  selector: 'app-asset-component',
  templateUrl: './asset.component.html'
})
export class AssetComponent {
  constructor(private assetService: AssetService) { }

  fileToUpload: File = null;

  handleFileInput(files: FileList) {
    this.fileToUpload = files.item(0);
  }

  public uploadFileToActivity() {
    debugger;
    this.assetService.postFile(this.fileToUpload).subscribe(data => {
      // do something, if upload success
      alert("Files has been uploaded to server");
      console.log("files uploaded");
    }, error => {
      console.log(error);
    });
  }
}
