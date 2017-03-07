;;; This is a dummy ini.scm file for testing the testing framework.

(define (+ . l)
  (if (null? l) 0
      (b+ (car l) (apply + (cdr l)))))

; Test incorrect return value
(define (caar x) (car (cdr x)))

; Test wrong number of arguments
(define (list l) l)

;; Binary and function
(define (and x y) (if x y x))

;; Binary map function
(define (map f l)
  (if (null? l) '()
      (cons (f (car l)) (map f (cdr l)))))
