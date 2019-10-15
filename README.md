# Лабораторная работа по дисциплине алгоритмы и анализ сложности "Задача о вершинном покрытии"

## Определения

**Вершинное покрытие** для неориентированного графа `G=(V,E)` — это множество его вершин `S`, 
такое, что у каждого ребра графа хотя бы один из концов входит в вершину из `S`.

**Размер вершинного покрытия** — это число входящих в него вершин.

## Пример
Изображённый граф, имеет вершинное покрытие `{1, 3, 5, 6}` размера 4. 
Однако оно не является наименьшим вершинным покрытием, поскольку существуют вершинные покрытия меньшего размера,
такие как `{2, 4, 5}` и `{1, 2, 4}`.
Задача о вершинном покрытии требует указать минимально возможный размер `k` вершинного покрытия для заданного графа.

![граф](https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/6n-graf.svg/1280px-6n-graf.svg.png)
