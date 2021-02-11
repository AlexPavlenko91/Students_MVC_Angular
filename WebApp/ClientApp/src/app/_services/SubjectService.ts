import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { SubjectModel } from "../_models/SubjectModel";
import { Service } from "./generic/Service";

@Injectable({ providedIn: 'root' })
export class SubjectService extends Service<SubjectModel>{
  constructor(http: HttpClient) {
    super(http);
    this.baseUrl = "api/Subject";
  }
}
