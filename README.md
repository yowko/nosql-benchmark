# nosql-benchmark

## MongoDB

|        Method |   Times |          Mean |      Error |     StdDev |        Median |
|-------------- |-------- |--------------:|-----------:|-----------:|--------------:|
| MongoDbInsert |     100 |      4.824 ms |  0.2087 ms |  0.6087 ms |      4.648 ms |
| MongoDbInsert |   10,000 |    111.686 ms |  2.2250 ms |  2.3807 ms |    111.603 ms |
| MongoDbInsert | 1,000,000 | 10,725.614 ms | 65.2694 ms | 61.0531 ms | 10,727.612 ms |


## Cassandra

|          Method |   Times |          Mean |        Error |       StdDev |
|---------------- |-------- |--------------:|-------------:|-------------:|
| CassandraInsert |     100 |      37.53 ms |     2.047 ms |     6.004 ms |
| CassandraInsert |   10,000 |   1,633.61 ms |    33.614 ms |    97.519 ms |
| CassandraInsert | 1,000,000 | 165,795.11 ms | 3,301.669 ms | 4,293.102 ms |


## CouchDB

|     Method |   Times |          Mean |         Error |       StdDev |
|----------- |-------- |--------------:|--------------:|-------------:|
| InsertTest |     100 |      36.62 ms |     0.7554 ms |     2.131 ms |
| InsertTest |   10,000 |   1,628.92 ms |    26.8867 ms |    25.150 ms |
| InsertTest | 1,000,000 | 174,499.33 ms | 2,222.5798 ms | 1,970.259 ms |



## RavenDB


|     Method |   Times |          Mean |        Error |     StdDev |
|----------- |-------- |--------------:|-------------:|-----------:|
| InsertTest |     100 |      44.04 ms |     1.477 ms |   4.332 ms |
| InsertTest |   10,000 |   1,066.53 ms |    21.480 ms |  43.877 ms |
| InsertTest | 1,000,000 | 102,426.60 ms | 1,157.901 ms | 966.900 ms |



## ArangoDB

|     Method |   Times |      Mean |     Error |    StdDev |    Median |
|----------- |-------- |----------:|----------:|----------:|----------:|
| InsertTest |     100 |  15.24 ms |  1.369 ms |  3.927 ms |  14.02 ms |
| InsertTest |   10,000 | 696.75 ms | 13.726 ms | 28.652 ms | 692.08 ms |
| InsertTest | 1,000,000 |        NA |        NA |        NA |        NA |


## PostgreSQL


|     Method |   Times |         Mean |       Error |      StdDev |       Median |
|----------- |-------- |-------------:|------------:|------------:|-------------:|
| InsertTest |     100 |     6.501 ms |   0.2907 ms |   0.8386 ms |     6.256 ms |
| InsertTest |   10,000 |    88.128 ms |   2.6015 ms |   6.8987 ms |    86.356 ms |
| InsertTest | 1,000,000 | 7,523.930 ms | 147.6126 ms | 220.9395 ms | 7,540.428 ms |



1. 100

    |     Method |   Mean |
    |----------- |-------- |
    |MongoDB|<font style="color:lightgreen">4.824 ms</font>|
    |Cassandra|37.53 ms|
    |CouchDB|36.62 ms|
    |RavenDB|<font style="color:red">44.04 ms</font>|
    |ArangoDB|15.24 ms|
    |PostgreSQL- json|6.501 ms|

2. 10,000

    |     Method |   Mean |
    |----------- |-------- |
    |MongoDB|111.686 ms |
    |Cassandra|<font style="color:red">1,633.61 ms</font>|
    |CouchDB|1,628.92 ms|
    |RavenDB|1,066.53 ms|
    |ArangoDB|696.75 ms|
    |PostgreSQL -json|<font style="color:lightgreen">88.128 ms</font>|

3. 1,000,000

    |     Method |   Mean |
    |----------- |-------- |
    |MongoDB|10,725.614 ms|
    |Cassandra|165,795.11 ms|
    |CouchDB|<font style="color:red">174,499.33 ms</font>|
    |RavenDB|102,426.60 ms|
    |ArangoDB|<font style="color:red">NA</font>|
    |PostgreSQL -json|<font style="color:lightgreen">7,523.930 ms</font>|





