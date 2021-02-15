import { IModel } from '../../_interfaces/imodel';
import { Guid } from 'guid-typescript';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { first, flatMap, shareReplay } from 'rxjs/operators';
import { IService } from '../abstract/IService';


@Injectable({ providedIn: 'root' })
export class Service<T extends IModel> implements IService<T> {

  private allItems: Observable<T[]>;
  protected baseUrl: string;

  public constructor(private http: HttpClient) { }

  public getAllItems(): Observable<T[]> {
    if (!this.allItems) {
      this.allItems = this.http.get<T[]>(this.baseUrl).pipe(shareReplay());
    }
    return this.allItems;
  }

  public getItemById(id: Guid): Observable<T> {
    return this.getAllItems().pipe(flatMap(result => result), first<T>(item => (item.id === id)));
  }

  public addItem(item: T): Observable<T> {
    return this.http.post<T>(this.baseUrl, item);
  }

  public updateItem(item: T): Observable<T> {
    return this.http.put<T>(this.baseUrl, item);
  }

  public deleteItem(id: Guid): Observable<any> {
    return this.http.delete(this.baseUrl + '/' + id);
  }

  public clearCache() {
    this.allItems = null;
  }
}

