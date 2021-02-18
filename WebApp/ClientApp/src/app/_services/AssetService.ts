import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({ providedIn: 'root' })
export class AssetService {
  private baseUrl: string;
  constructor(private http: HttpClient) {
    this.baseUrl = '/Asset/Add';
    //this.httpClient = http;
  }
  //httpClient: any;


  postFile(fileToUpload: File): any {
    debugger;
    const endpoint = this.baseUrl;
    const formData: FormData = new FormData();
    formData.append('fileKey', fileToUpload, fileToUpload.name);
    return this.http
      .post(endpoint, formData, {});
     // .subscribe(_data => { debugger; });

    // .map(() => { return true; })
    // .catch((e) => this.handleError(e));
  }
  handleError(e: any) {
    throw new Error("Something went wrong");
  }
}
