-- Migration: Alterar coluna foto para armazenar nome/caminho do arquivo em vez de blob
-- Executado pelo usuário: ALTER TABLE funcionarios MODIFY foto VARCHAR(500);

ALTER TABLE funcionarios MODIFY foto VARCHAR(500);