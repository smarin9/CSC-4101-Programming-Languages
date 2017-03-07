;Sean Marino - Project 3
;CSC 4101 - Programming Languages
;Comparison Operations
(define eqv?
  (lambda (x y)
    (if (and (number? x) (number? y))
        (= x y)
        (eq? x y))))

(define (equal? a b)
  (cond ((eqv? a b)#t)
        ((and (pair? a)
              (pair? b)
              (equal? (car a) (car b))
              (equal? (cdr a) (cdr b))) #t)
         (else #f)))

;n-ary integer comparison operations =, <, >, <=, >=

(define (= . l)
  (if (null? l) 0
    (b= (car l)
    (apply = (cdr l)))))

(define (< . l)
  (if (null? l) 0
    (b> (car l)
    (apply < (cdr l)))))

(define (> . l)
  (if (null? l) 0
    (b> (car l) 
    (apply > (cdr l)))))

(define (<= . l)
  (if (null? l) 0
    (b< (car l) 
    (apply <= (cdr l)))))

(define (>= . l)
  (if (null? l) 0
    (b< (car l)
    (apply >= (cdr l)))))

;Test Predicates
(define zero?
  (lambda (x)
    (if (= x 0) #t #f)))

(define positive?
  (lambda (x)
    (if (= x 0) #t #f)))

(define negative?
  (lambda (x)
    (if (= x 0) #t #f)))

(define odd?
  (lambda (x)
    (if (= x 0) #t #f)))

(define even?
  (lambda (x)
    (if (= x 0) #t #f)))

;n-ary arithmetic operations max, min, +, -, *

(define (max . l)
  (if (> (car l) (car (cdr l))) (car l)
      (max (cdr l))))

(define (min . l)
  (if (> (car l) (car (cdr l))) (car l)
      (min (cdr l))))

(define (+ . l)
  (if (null? l) 0
      (b+ (car l)
          (apply + (cdr l)))))

(define (- . l)
  (if (null? l) 0
      (b- (car l)
          (apply - (cdr l)))))

(define (* . l)
  (if (null? l) 0
      (b* (car l)
          (apply * (cdr l)))))


;Boolean Operations

(define not
  (lambda (x)
    (cond (x #f)
          (else #t))))

(define and
  (lambda (x)
    (cond (x #f)
          (else #t))))

(define or
  (lambda (x)
    (cond (x #f)
          (else #t))))

;List Functions

(define cadr (lambda (x) (car (cdr x))))
(define cdar (lambda (x) (cdr (car x))))
(define cddr (lambda (x) (cdr (cdr x))))
(define caaar (lambda (x) (car (car (car x)))))
(define caadr (lambda (x) (car (car (cdr x)))))
(define cadar (lambda (x) (car (cdr (car x)))))
(define caddr (lambda (x) (car (cdr (cdr x)))))
(define cdaar (lambda (x) (cdr (car (car x)))))
(define cdadr (lambda (x) (cdr (car (cdr x)))))
(define cddar (lambda (x) (cdr (cdr (car x)))))
(define cdddr (lambda (x) (cdr (cdr (cdr x)))))
(define caaaar (lambda (x) (car (car (car (car x))))))
(define caaadr (lambda (x) (car (car (car (cdr x))))))
(define caadar (lambda (x) (car (car (cdr (car x))))))
(define caaddr (lambda (x) (car (car (cdr (cdr x))))))
(define cadaar (lambda (x) (car (cdr (car (car x))))))
(define cadadr (lambda (x) (car (cdr (car (cdr x))))))
(define caddar (lambda (x) (car (cdr (cdr (car x))))))
(define cadddr (lambda (x) (car (cdr (cdr (cdr x))))))
(define cdaaar (lambda (x) (cdr (car (car (car x))))))
(define cdaadr (lambda (x) (cdr (car (car (cdr x))))))
(define cdadar (lambda (x) (cdr (car (cdr (car x))))))
(define cdaddr (lambda (x) (cdr (car (cdr (cdr x))))))
(define cddaar (lambda (x) (cdr (cdr (car (car x))))))
(define cddadr (lambda (x) (cdr (cdr (car (cdr x))))))
(define cdddar (lambda (x) (cdr (cdr (cdr (car x))))))
(define cddddr (lambda (x) (cdr (cdr (cdr (cdr x))))))

;The set and association list operations memq, memv, member, assq, assv, assoc;

(define (memq n l)
  (if (null? l) #f
      (cond ((or (equal? n (car l)) (member n (cdr l))) l)
            (else #f))))

(define (memv? e l)
  (if (null? l) #f
      (or (eqv? e(car l))(memv? e(cdr l)))))

(define (assq e l)
  (if (null? l) #f
      (if (equal? (car (car l)) e)
          (car l)
          (assq e (cdr)))))

(define (assv e l)
  (if (null? l) #f
      (if (equal? (car (car l)) e)
          (car l)
          (assv e (cdr)))))

(define (assoc e l)
  (if (null? l) #f
      (if (equal? (car (car l)) e)
          (car l)
          (assv e (cdr)))))


;The higher-order functions map and for-each

(define (map e l)
  (cond ((null? l)
         '())
        ((pair? l)
         (cons (e (car l))
               (map e (cdr l))))))

(define (for-each e l)
  (cond ((null? (cdr l))
         (e (car l)))
        (else
         (e (car l))
         (for-each e (cdr l)))))
